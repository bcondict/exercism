export const colorCode = (color:string): number  => {
  // eslint-disable-next-line @typescript-eslint/no-use-before-define
  return COLORS.indexOf(color)
}

export const COLORS: string[] = [
  'black',
  'brown',
  'red',
  'orange',
  'yellow',
  'green',
  'blue',
  'violet',
  'grey',
  'white'
]
