export function age(planet: string, seconds: number): number {
  return +((seconds / EARTH_YEAR_SECONDS) / TIME_PLANETS[planet]).toFixed(2);
}

const EARTH_YEAR_SECONDS = 31_557_600;

interface Planets {[key: string]: number;}
const TIME_PLANETS: Planets = {
  mercury: 0.2408467,
  venus: 0.61519726,
  earth: 1.0,
  mars: 1.8808158,
  jupiter: 11.862615,
  saturn: 29.447498,
  uranus: 84.016846,
  neptune: 164.79132
};
