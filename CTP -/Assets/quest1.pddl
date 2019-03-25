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
      (border abandonedhouse pond)
      (border abandonedhouse road)
      (border pond mountain)
      (border pond abandonedhouse)
      (border forest road)
      (border forest mine)
      (border town city)
      (border road abandonedhouse)
      (border road forest)
      (border mine forest)
      (border tundra mountain)
      (border tundra city)
      (border mountain pond)
      (border mountain tundra)
      (border city town)
      (border city tundra)
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
      (at npc abandonedhouse)
   )
  (:goal(and (at npc town)))
)