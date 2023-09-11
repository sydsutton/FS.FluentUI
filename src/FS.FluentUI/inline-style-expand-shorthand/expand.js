//*This file was copied from https://github.com/robinweser/inline-style-expand-shorthand to minimize the amount of JS dependencies

import expandProperty from './expandProperty'

export default function expand(style) {
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
