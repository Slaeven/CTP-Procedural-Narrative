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
      (border mountain mine)
      (border mountain town)
      (border abandonedhouse road)
      (border pond city)
      (border pond town)
      (border mine mountain)
      (border tundra city)
      (border tundra forest)
      (border city pond)
      (border city tundra)
      (border forest road)
      (border forest tundra)
      (border road abandonedhouse)
      (border road forest)
      (border town mountain)
      (border town pond)
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
      (at npc town)
   )
  (:goal(and (at npc mountain)))
)