export function decodedValue(colors: Array<string>): number {
  const COLORS: string[] = [
    "black",
    "brown",
    "red",
    "orange",
    "yellow",
    "green",
    "blue",
    "violet",
    "grey",
    "white"
    ]
    return +`${COLORS.indexOf(colors[0])}${COLORS.indexOf(colors[1])}`;
}

