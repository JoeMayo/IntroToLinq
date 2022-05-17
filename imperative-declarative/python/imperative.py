names = ["Sam Young", "Pat Smith", "Joe Mayo"]

nonJoeNames = []

for i in range(len(names)):
  name = names[i]

  if not name.endswith("Mayo"):
    nonJoeNames.append(name)


for name in nonJoeNames:
  print(name)