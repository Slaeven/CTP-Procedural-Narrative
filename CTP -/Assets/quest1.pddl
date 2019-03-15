(define (problem goblinking)
   (:domain magic-world)
   (:objects
      npc - player
      king blacksmith shopkeep miner lumberjack fisher - person
      goblin - minor
      gobking - major
      town forest road city mine pond mountain tundra abandonedhouse  - location
      quest sword magic enchantedsword wood water bucket ore pickaxe - object
   )
   (:init
      (border abandonedhouse road)
      (border pond town)
      (border pond mine)
      (border pond mountain)
      (border forest town)
      (border forest mine)
      (border town pond)
      (border town forest)
      (border road city)
      (border road abandonedhouse)
      (border mine pond)
      (border mine forest)
      (border tundra mountain)
      (border tundra city)
      (border mountain pond)
      (border mountain tundra)
      (border city road)
      (border city tundra)
      (at king city)
      (at blacksmith mine)
      (at miner mine)
      (at lumberjack town)
      (at shopkeep town)
      (at fisher pond)
   )
  (:goal(and (at abandonedhouse npc)))
)