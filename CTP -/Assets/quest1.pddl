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
      (border mountain abandonedhouse)
      (border mountain mine)
      (border abandonedhouse pond)
      (border abandonedhouse tundra)
      (border abandonedhouse mountain)
      (border pond city)
      (border pond abandonedhouse)
      (border mine tundra)
      (border mine forest)
      (border mine mountain)
      (border tundra city)
      (border tundra road)
      (border tundra abandonedhouse)
      (border tundra mine)
      (border city town)
      (border city pond)
      (border city tundra)
      (border forest road)
      (border forest mine)
      (border road town)
      (border road tundra)
      (border road forest)
      (border town city)
      (border town road)
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
  (:goal(and (at npc 3)))
)