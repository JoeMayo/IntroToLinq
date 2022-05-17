const names = ["Sam Young", "Pat Smith", "Joe Mayo"];

const nonJoeNames = [];

for (let i = 0; i < names.length; i++) {
  let name = names[i];

  if (!name.endsWith("Mayo")) {
    nonJoeNames.push(name);
  }
}

nonJoeNames.forEach((name) => {
  console.log(name);
});
