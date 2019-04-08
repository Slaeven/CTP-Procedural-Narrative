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
      (border city pond)
      (border city tundra)
      (border city town)
      (border forest mine)
      (border forest road)
      (border mountain mine)
      (border mountain abandonedhouse)
      (border pond abandonedhouse)
      (border pond city)
      (border mine tundra)
      (border mine forest)
      (border mine mountain)
      (border road tundra)
      (border road town)
      (border road forest)
      (border tundra abandonedhouse)
      (border tundra city)
      (border tundra mine)
      (border tundra road)
      (border abandonedhouse mountain)
      (border abandonedhouse pond)
      (border abandonedhouse tundra)
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
  (:goal(and (has-water npc)))
)