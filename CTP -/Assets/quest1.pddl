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
      (border abandonedhouse forest)
      (border abandonedhouse mountain)
      (border pond mine)
      (border pond tundra)
      (border pond city)
      (border pond abandonedhouse)
      (border forest city)
      (border forest abandonedhouse)
      (border town mountain)
      (border road mine)
      (border road tundra)
      (border mine pond)
      (border mine road)
      (border tundra mountain)
      (border tundra pond)
      (border tundra road)
      (border mountain abandonedhouse)
      (border mountain town)
      (border mountain tundra)
      (border city pond)
      (border city forest)
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
      (at npc road)
   )
  (:goal(and (at npc tundra)))
)