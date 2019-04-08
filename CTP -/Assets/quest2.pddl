(define (problem mk5)
   (:domain magic-world)
   (:objects
      npc - character
      kingperson - king
      blacksmithperson - blacksmith
      shopkeepperson - shopkeep
      minerperson - miner
      lumberjackperson - lumberjack
      fisherperson - fisher
      goblin - minor
      gobking - major
      questobject - quest
      swordobject - sword
      woodobject - wood
      waterobject - water
      bucketobject - bucket
      oreobject - ore
      pickaxeobject - pickaxe
      fishobject - fish
      town forest road city mine pond mountain tundra abandonedhouse  - location
   )
   (:init
      (border city road)
      (border city town)
      (border forest tundra)
      (border forest town)
      (border mountain pond)
      (border mountain abandonedhouse)
      (border pond road)
      (border pond mountain)
      (border mine abandonedhouse)
      (border road city)
      (border road pond)
      (border tundra forest)
      (border abandonedhouse mountain)
      (border abandonedhouse mine)
      (border town city)
      (border town forest)
      (at kingperson city)
      (at blacksmithperson mine)
      (at minerperson mine)
      (at lumberjackperson town)
      (at shopkeepperson town)
      (at fisherperson pond)
      (at fishobject pond)
      (at woodobject forest)
      (at oreobject mine)
      (at waterobject pond)
      (at bucketobject town)
      (at swordobject town)
      (at pickaxeobject mine)
      (at npc mine)
   )
  (:goal(and (at npc forest)))
)