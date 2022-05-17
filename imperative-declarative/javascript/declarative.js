const names = ["Sam Young", "Pat Smith", "Joe Mayo"];

const nonJoeNames = names
  .filter((name) => !name.endsWith("Mayo"))
  .map((name) => name);

nonJoeNames.forEach((name) => {
  console.log(name);
});
