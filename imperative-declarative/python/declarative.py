names = ["Sam Young", "Pat Smith", "Joe Mayo"];

filteredNames = filter(lambda name: not name.endswith("Mayo"), names)
mappedNames = map(lambda name: name, filteredNames)
nonJoeNames = list(mappedNames)

# nonJoeNames = \
#   list( \
#     map( \
#       lambda name: name, \
#       filter(lambda name: not name.endswith("Mayo"), names)))

for name in nonJoeNames:
  print(name)