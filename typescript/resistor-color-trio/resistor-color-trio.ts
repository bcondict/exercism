export function decodedResistorValue(colors: string[]) {
  const fisrtValue = COLORS.indexOf(colors[0]);
  const secondValue = COLORS.indexOf(colors[1]);
  const numberOfZeros = COLORS.indexOf(colors[2]);

  let resistorValue: string = `${fisrtValue !== 0 ? fisrtValue: ''}${secondValue}`;
  let unity:string = '';

  resistorValue = resistorValue.concat("0".repeat(numberOfZeros));

  [unity, resistorValue] = unityConversor(+resistorValue);

  return `${resistorValue} ${unity}ohms`;
}

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

function unityConversor (value: number) {
  let unity: string = "";
  const notZero: boolean = value !== 0;

  if (notZero && value % 1000 === 0)
  {
    unity = "kilo"
    value = value / 1000;
  }
  if (notZero && value % 1000 == 0)
  {
    unity = "mega"
    value = value / 1000;
  }
  if (notZero && value % 1000 == 0)
  {
    unity = "giga"
    value = value / 1000;
  }

  return [unity, String(value)];
}
