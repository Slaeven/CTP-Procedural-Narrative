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
      (border city mine)
      (border city abandonedhouse)
      (border forest tundra)
      (border forest town)
      (border mountain pond)
      (border mountain town)
      (border pond road)
      (border pond mountain)
      (border mine city)
      (border road pond)
      (border tundra abandonedhouse)
      (border tundra forest)
      (border abandonedhouse city)
      (border abandonedhouse tundra)
      (border town forest)
      (border town mountain)
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
      (at npc forest)
   )
  (:goal(and (has-wood npc)))
)