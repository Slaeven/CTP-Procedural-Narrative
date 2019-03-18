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
      (border abandonedhouse road)
      (border abandonedhouse mountain)
      (border pond forest)
      (border pond mine)
      (border forest road)
      (border forest pond)
      (border town tundra)
      (border road tundra)
      (border road abandonedhouse)
      (border road forest)
      (border mine city)
      (border mine pond)
      (border tundra mountain)
      (border tundra town)
      (border tundra road)
      (border mountain abandonedhouse)
      (border mountain tundra)
      (border city mine)
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
      (at npc city)
   )
  (:goal(and (at npc mountain)))
)