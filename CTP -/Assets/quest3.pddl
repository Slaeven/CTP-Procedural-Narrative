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
      (border city mountain)
      (border forest mountain)
      (border forest mine)
      (border mountain city)
      (border mountain forest)
      (border pond mine)
      (border pond abandonedhouse)
      (border pond town)
      (border mine tundra)
      (border mine forest)
      (border mine pond)
      (border road abandonedhouse)
      (border road town)
      (border tundra abandonedhouse)
      (border tundra mine)
      (border abandonedhouse pond)
      (border abandonedhouse road)
      (border abandonedhouse tundra)
      (border town pond)
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
      (at npc tundra)
   )
  (:goal(and (at npc mountain)))
)