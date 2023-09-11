//*This file was copied from https://github.com/robinweser/inline-style-expand-shorthand to minimize the amount of JS dependencies

import expandProperty from './expandProperty'

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

export default function expandWithMerge(style) {
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
