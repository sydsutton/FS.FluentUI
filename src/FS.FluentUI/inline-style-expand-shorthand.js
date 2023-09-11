//*This file was copied from https://github.com/robinweser/inline-style-expand-shorthand to minimize the amount of JS dependencies


const LENGTH_UNIT = /(em|ex|ch|rem|vw|vh|vmin|vmax|cm|mm|q|in|pt|pc|px|dpi|dpcm|dppx|%|auto)$/i
const CALC = /^(calc\()/i
const VAR = /^(var\()/i
const BORDER_STYLE = /^(dashed|dotted|double|groove|hidden|inset|none|outset|ridge|solid)$/i
const BORDER_WIDTH = /^(thick|medium|think)$/i
const PURE_NUMBER = /^\d+$/
const GLOBAL_VALUES = ['inherit', 'initial', 'unset', 'revert', 'revert-layer'];

function splitShorthand(value) {
  let values = ['']
  let openParensCount = 0

  const trimmedValue = value.trim()

  for (let index = 0; index < trimmedValue.length; index += 1) {
    if (trimmedValue.charAt(index) === ' ' && openParensCount === 0) {
      // Add new value
      values.push('')
    } else {
      // Add the current character to the current value
      values[values.length - 1] =
        values[values.length - 1] + trimmedValue.charAt(index)
    }

    // Keep track of the number of parentheses that are yet to be closed.
    // This is done to avoid splitting at whitespaces within CSS functions.
    // E.g.: `calc(1px + 1em)`
    if (trimmedValue.charAt(index) === '(') {
      openParensCount++
    } else if (trimmedValue.charAt(index) === ')') {
      openParensCount--
    }
  }

  return values
}

function parseBorder(value, resolve) {
  const values = splitShorthand(value)
  const longhands = {}

  values.forEach(val => {
    if (val.match(BORDER_STYLE) !== null) {
      longhands[resolve('Style')] = val
    } else if (
      val.match(BORDER_WIDTH) !== null ||
      val.match(LENGTH_UNIT) !== null ||
      val.match(CALC) !== null ||
      val === '0'
    ) {
      longhands[resolve('Width')] = val
    } else {
      longhands[resolve('Color')] = val
    }
  })

  return longhands
}

function parseCircular(value, resolve) {
  const [Top, Right = Top, Bottom = Top, Left = Right] = splitShorthand(value)

  return {
    [resolve('Top')]: Top,
    [resolve('Right')]: Right,
    [resolve('Bottom')]: Bottom,
    [resolve('Left')]: Left,
  }
}

function parseFlowRelativePosition(value, resolve) {
  const [Start, End = Start] = splitShorthand(value)

  return {
    [resolve('Start')]: Start,
    [resolve('End')]: End,
  }
}

function groupBy(values, divider) {
  const groups = [[]];

  values.forEach(val => {
    if (val === divider) {
      groups.push([]);
    } else {
      groups[groups.length - 1].push(val);
    }
  });

  return groups;
}

function parseBorderRadius(value) {
  const [first = [], second = []] = groupBy(splitShorthand(value), '/')
  const [Top, Right = Top, Bottom = Top, Left = Right] = first
  const [Top2, Right2 = Top2, Bottom2 = Top2, Left2 = Right2] = second

  return {
    borderTopLeftRadius: [Top, Top2].filter(Boolean).join(' '),
    borderTopRightRadius: [Right, Right2].filter(Boolean).join(' '),
    borderBottomRightRadius: [Bottom, Bottom2].filter(Boolean).join(' '),
    borderBottomLeftRadius: [Left, Left2].filter(Boolean).join(' '),
  }
}

const textDecorationLineValues = new Set(GLOBAL_VALUES.concat(['none', 'underline', 'overline', 'line-through', 'blink']));
const textDecorationStyleValues = new Set(GLOBAL_VALUES.concat(['solid', 'double', 'dotted', 'dashed', 'wavy']));

function parseTextDecoration(value) {
  // https://www.w3.org/TR/css-text-decor-3/#text-decoration-property
  // https://w3c.github.io/csswg-drafts/css-text-decor/#text-decoration-property
  const values = splitShorthand(value)

  if (values.length === 1) {
    // A text-decoration declaration that omits both the text-decoration-color and text-decoration-style
    // values is backwards-compatible with CSS Levels 1 and 2.
    if (values[0] === 'initial') {
      return {
        textDecorationLine: 'none'
      }
    }
    return {
      textDecorationLine: values[0]
    }
  }

  const [left, middle, right] = values;

  const lineValue = []
  let colorValue = ''
  let styleValue = ''

  const extractValues = (v) => {
    if (v) {
      if (textDecorationLineValues.has(v)) {
        if (lineValue.length === 0 || !lineValue.includes(v)) {
          lineValue.push(v);
        } else {
          // Repeated line value, invalid, bail out!
          return true;
        }
      } else if (textDecorationStyleValues.has(v)) {
        styleValue = v;
      } else {
        colorValue = v;
      }
    }
    // Valid, continue
    return false;
  };

  if (extractValues(left) || extractValues(middle) || extractValues(right)) {
    // Invalid, ignore
    return {};
  }

  lineValue.sort(); // Ensure the sorting is always in the same order.
  const textDecorationLine = lineValue.length ? lineValue.join(' ') : 'none';

  return {
    textDecorationLine,
    textDecorationStyle: styleValue || 'solid',
    textDecorationColor: colorValue || 'currentColor',
  }
}

const circularExpand = {
  borderWidth: key => 'border' + key + 'Width',
  borderColor: key => 'border' + key + 'Color',
  borderStyle: key => 'border' + key + 'Style',
  padding: key => 'padding' + key,
  margin: key => 'margin' + key,
  scrollPadding: key => 'scrollPadding' + key,
  scrollMargin: key => 'scrollMargin' + key,
}

const borderExpand = {
  borderLeft: key => 'borderLeft' + key,
  borderTop: key => 'borderTop' + key,
  borderRight: key => 'borderRight' + key,
  borderBottom: key => 'borderBottom' + key,
  outline: key => 'outline' + key,
}

const flowRelativePositionExpand = {
  paddingInline: key => 'paddingInline' + key,
  paddingBlock: key => 'paddingBlock' + key,
  marginInline: key => 'marginInline' + key,
  marginBlock: key => 'marginBlock' + key,
}

function parseFlex(value) {
  let values = [''];

  // https://developer.mozilla.org/en-US/docs/Web/CSS/flex#values
  switch (value.trim()) {
    case 'initial':
      // "flex: initial" is equivalent to "flex: 0 1 auto"
      values = splitShorthand('0 1 auto');
      break;

    case 'auto':
      // "flex: auto" is equivalent to "flex: 1 1 auto"
      values = splitShorthand('1 1 auto');
      break;

    case 'none':
      // "flex: none" is equivalent to "flex: 0 0 auto"
      values = splitShorthand('0 0 auto');
      break;

    default:
      values = splitShorthand(value);
      break;
  }

  // https://developer.mozilla.org/en-US/docs/Web/CSS/flex#syntax
  // https://www.w3.org/TR/css-flexbox-1/

  // Expand one-value syntax to three-value syntax
  if (values.length === 1) {
    // One-value syntax
    const val = values[0]
    if (PURE_NUMBER.test(val)) {
      // flex value
      values = splitShorthand(val + ' 1 0');
    } else {
      // It is a width value (flex-basis)
      values = splitShorthand('1 1 ' + val);
    }
  }

  const longhands = {}

  if (values.length === 2) {
    // Two-value syntax
    longhands.flexGrow = values[0];

    if (
      values[1].match(PURE_NUMBER) !== null
    ) {
      // The second value appears to be a shrink factor
      longhands.flexShrink = values[1];
    } else {
      // The second value appears to be width
      longhands.flexBasis = values[1];
    }
  } else {
    // Three-value syntax
    longhands.flexGrow = values[0];
    longhands.flexShrink = values[1];
    longhands.flexBasis = values[2];
  }

  // According to the spec: Authors are encouraged to control flexibility using the flex shorthand rather than with its longhand
  // properties directly, as the shorthand correctly resets any unspecified components to accommodate common uses.
  //
  // Thus in order to maintain the correct behavior, we have to reset any unspecified longhand properties to their default values.

  // Add default value, initialized value is "0 1 auto"
  if (typeof longhands.flexGrow === 'undefined') {
    longhands.flexGrow = '0';
  }
  if (typeof longhands.flexShrink === 'undefined') {
    longhands.flexShrink = '1';
  }
  if (typeof longhands.flexBasis === 'undefined') {
    longhands.flexBasis = 'auto';
  }

  return longhands
}

function parseOverflow(value) {
  // https://www.w3.org/TR/css-overflow-3/#overflow-properties
  // The overflow property is a shorthand property that sets the specified values of overflow-x
  // and overflow-y in that order. If the second value is omitted, it is copied from the first.
  const [overflowX, overflowY = overflowX] = splitShorthand(value)

  return {
    overflowX,
    overflowY
  }
}

function parseGap(value) {
  // https://w3c.github.io/csswg-drafts/css-align/#gap-shorthand
  const [rowGap, columnGap = rowGap] = splitShorthand(value)
  // This property is a shorthand that sets row-gap and column-gap in one declaration. If <'column-gap'> is omitted, it’s set to the same value as <'row-gap'>.
  return {
    rowGap,
    columnGap
  }
}

const flexDirectionValues = new Set(GLOBAL_VALUES.concat(['row', 'row-reverse', 'column', 'column-reverse']))
const flexWrapValues = new Set(GLOBAL_VALUES.concat(['nowrap', 'wrap', 'reverse']))

function parseFlexFlow(value) {
  // https://w3c.github.io/csswg-drafts/css-flexbox/#flex-flow-property
  // initial value is specified individually for each of the flex-direction and flex-wrap properties
  let flexDirection = '';
  let flexWrap = '';
  const [left, right] = splitShorthand(value)

  const extractFlexFlowValue = (value) => {
    if (value) {
      if (flexDirectionValues.has(value)) {
        if (flexDirection !== '') {
          // flex-direction has already been set, original value invalid
          return true;
        }
        flexDirection = value;
      } else if (flexWrapValues.has(value)) {
        if (flexWrap !== '') {
          // flex-wrap has already been set, original value invalid
          return true;
        }
        flexWrap = value;
      } else {
        // invalid value
        return true;
      }
    }

    return false;
  }

  if (extractFlexFlowValue(left) || extractFlexFlowValue(right)) {
    // invalid value, ignore both values
    return {};
  }

  return {
    // only fallback to default value when original value is valid
    flexDirection: flexDirection || 'row',
    flexWrap: flexWrap || 'nowrap'
  }
}

// https://w3c.github.io/csswg-drafts/css-align/#place-content
function parsePlaceContent(value) {
  // The first value is assigned to align-content.
  // The second value is assigned to justify-content
  let [alignContent, justifyContent] = splitShorthand(value)
  if (!justifyContent && alignContent) {
    // if omitted, ...
    if (
      alignContent === 'left'
      || alignContent === 'right'
      || alignContent === 'first'
      || alignContent === 'last'
    ) {
      // invalid value, ignore both values
      return {}
    }
    if (alignContent === 'baseline') {
      // ..., unless that value is a <baseline-position> in which case it is defaulted to start.
      justifyContent = 'start'
    } else {
      // ..., it is copied from the first value
      justifyContent = alignContent
    }
  }

  return {
    alignContent,
    justifyContent
  }
}

// https://w3c.github.io/csswg-drafts/css-align/#place-items-property
function parsePlaceItems(value) {
  // This shorthand property sets both the align-items and justify-items properties in a single declaration. The first value is assigned to align-items. The second value is assigned to justify-items; if omitted, it is copied from the first value.
  const [alignItems, justifyItems = alignItems] = splitShorthand(value);
  return {
    alignItems,
    justifyItems
  }
}

function parsePlaceSelf(value) {
  // https://w3c.github.io/csswg-drafts/css-align/#place-self-property
  const [alignSelf, justifySelf = alignSelf] = splitShorthand(value);
  return {
    alignSelf,
    justifySelf
  }
}

// https://w3c.github.io/csswg-drafts/css-transitions/#transition-shorthand-property
// Since transition can accept multiple values, we will run extraction on each value
const extractTransition = (value) => {
  const values = splitShorthand(value)

  if (values.length === 1) {
    if (GLOBAL_VALUES.includes(values[0])) {
      return {
        transitionProperty: values[0],
        transitionDuration: values[0],
        transitionDelay: values[0],
        transitionTimingFunction: values[0]
      }
    } else if (values[0] === 'all' || values[0] === 'none') {
      return {
        transitionProperty: values[0],
        transitionDuration: '0s', // https://w3c.github.io/csswg-drafts/css-transitions/#transition-duration-property
        transitionDelay: '0s', // https://w3c.github.io/csswg-drafts/css-transitions/#transition-delay-property
        transitionTimingFunction: 'ease' // https://w3c.github.io/csswg-drafts/css-transitions/#transition-timing-function-property
      }
    }
  }

  // Note that order is important within the items in this property: the first value that can be parsed as a time is assigned to the transition-duration, and the second value that can be parsed as a time is assigned to transition-delay.
  const [
    transitionProperty,
    transitionDuration = '0s',
    transitionDelay = '0s',
    transitionTimingFunction = 'ease'
  ] = values

  return {
    transitionProperty,
    transitionDuration,
    transitionDelay,
    transitionTimingFunction
  }
}
// https://w3c.github.io/csswg-drafts/css-transitions/#transition-shorthand-property
function parseTransition(value) {
  if (!value.includes(',')) {
    // single value, let's do fast path
    return extractTransition(value)
  }

  const transitions = value.split(',').map(extractTransition)
  // merge multiple transitions
  // See https://developer.mozilla.org/en-US/docs/Web/CSS/transition#syntax for examples
  // The merge is adapted from microsoft/griffel, which is also an Atomic CSS-in-JS library
  // https://github.com/microsoft/griffel/blob/76662f70e846523bd1ab663f3340d4906333c795/packages/core/src/shorthands/transition.ts#LL64-L80C5
  return transitions.reduce(
    (
      acc,
      {
        transitionProperty,
        transitionDuration,
        transitionDelay,
        transitionTimingFunction
      },
      index
    ) => {
      if (index === 0) {
        acc.transitionProperty = transitionProperty;
        acc.transitionDuration = transitionDuration;
        acc.transitionDelay = transitionDelay;
        acc.transitionTimingFunction = transitionTimingFunction;
      } else {
        acc.transitionProperty += `, ${transitionProperty}`;
        acc.transitionDuration += `, ${transitionDuration}`;
        acc.transitionDelay += `, ${transitionDelay}`;
        acc.transitionTimingFunction += `, ${transitionTimingFunction}`;
      }
      return acc;
    },
    {},
  );
}

function parseInset(value) {
  const [top, right = top, bottom = top, left = right] = splitShorthand(value);
  return {
    top,
    right,
    bottom,
    left,
  };
}

function expandProperty(property, value) {
  // special expansion for the border property as its 2 levels deep
  if (property === 'border') {
    const longhands = parseBorder(value.toString(), key => 'border' + key)

    var result = {}
    for (let property in longhands) {
      Object.assign(result, expandProperty(property, longhands[property]))
    }

    return result
  }

  if (property === 'flex') {
    return parseFlex(value.toString())
  }

  if (property === 'borderRadius') {
    return parseBorderRadius(value.toString())
  }

  if (property === 'textDecoration') {
    return parseTextDecoration(value.toString())
  }

  if (property === 'overflow') {
    return parseOverflow(value.toString())
  }

  if (property === 'gap') {
    return parseGap(value.toString())
  }

  if (property === 'flexFlow') {
    return parseFlexFlow(value.toString())
  }

  if (property === 'placeContent') {
    return parsePlaceContent(value.toString())
  }

  if (property === 'placeItems') {
    return parsePlaceItems(value.toString())
  }

  if (property === 'placeSelf') {
    return parsePlaceSelf(value.toString())
  }

  if (property === 'transition') {
    return parseTransition(value.toString())
  }

  if (property === 'inset') {
    return parseInset(value.toString())
  }

  if (circularExpand[property]) {
    return parseCircular(value.toString(), circularExpand[property])
  }

  if (borderExpand[property]) {
    return parseBorder(value.toString(), borderExpand[property])
  }

  if (flowRelativePositionExpand[property]) {
    return parseFlowRelativePosition(value.toString(), flowRelativePositionExpand[property])
  }
}

function preExpand(property, value) {
  if (Array.isArray(value)) {
    const result = {}

    value.forEach(item => {
      const itemResult = expandProperty(property, item)

      if (itemResult) {
        Object.keys(itemResult).forEach(itemProperty => {
          result[itemProperty] = result[itemProperty] || []
          result[itemProperty].push(itemResult[itemProperty])
        })
      }
    })

    if (Object.keys(result).length) {
      return result
    }

    return null
  }

  return expandProperty(property, value)
}


function mergeBase(longhands, base) {
    for (const property in longhands) {
      if (base.hasOwnProperty(property)) {
        longhands[property] = base[property]
      }
    }

    return longhands
  }

  const priority = [
    'borderLeft',
    'borderRight',
    'borderBottom',
    'borderTop',
    'borderWidth',
    'borderStyle',
    'borderColor',
  ]


function expand(style) {
    for (const property in style) {
      const value = style[property]

      if (typeof value === 'string' || typeof value === 'number') {
        const expansion = expandProperty(property, value)

        if (expansion) {
          Object.assign(style, expansion)
          delete style[property]
        }
      } else if (value === null) {
        // should skip
      } else if (Array.isArray(value)) {
        if (property === 'extend') {
          value.map(expand)
        } else {
          const expansion = expandProperty(property, value)

          if (expansion) {
            Object.assign(style, expansion)
            delete style[property]
          }
        }
      } else if (typeof value === 'object') {
        expand(value)
      }
    }

    return style
  }

function expandWithMerge(style) {
    // we reverse the key order to make sure more specific properties
    // will always overwrite the unspecific shorthands
    const sortedKeys = Object.keys(style)
      .sort((a, b) =>
        priority.indexOf(a) && priority.indexOf(b)
          ? priority.indexOf(a) > priority.indexOf(b)
          : a > b || -1
      )
      .reverse()

    for (const property of sortedKeys) {
      const value = style[property]

      if (typeof value === 'string' || typeof value === 'number') {
        const expansion = expandProperty(property, value)

        if (expansion) {
          Object.assign(style, mergeBase(expansion, style))
          delete style[property]
        }
      } else if (value === null) {
        // should skip
      } else if (Array.isArray(value)) {
        if (property === 'extend') {
          value.map(expandWithMerge)
        } else {
          const expansion = expandProperty(property, value)

          if (expansion) {
            Object.assign(style, mergeBase(expansion, style))
            delete style[property]
          }
        }
      } else if (typeof value === 'object') {
        expandWithMerge(value)
      }
    }

    return style
  }


export { expand, expandProperty, expandWithMerge }
