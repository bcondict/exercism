export function toRna(DNA: string): string {
  // throw new Error('Remove this statement and implement this function')
  let RNA:string = "";

  for (let letter of DNA) {
    if (letter == 'C')
      RNA += 'G';
    else if (letter == 'G')
      RNA += 'C';
    else if (letter == 'A')
      RNA += 'U';
    else if (letter == 'T')
      RNA += 'A';
    else {
      throw new Error("Invalid input DNA.");
    }
  }

  return RNA;
}
