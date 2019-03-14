(define (problem goblinking)
   (:domain magic-world)
   (:objects
      npc - player
      king blacksmith shopkeep miner lumberjack fisher - person
      goblin - minor
      gobking - major
      town forest road city blacksmithy pond mountain tundra abandonedhouse  - location
      quest sword magic enchantedsword wood water bucket ore pickaxe - object
   )
   (:init
      (border abandonedhouse road)
      (border pond town)
      (border pond mountain)
      (border forest town)
      (border forest road)
      (border town pond)
      (border town forest)
      (border road abandonedhouse)
      (border road forest)
      (border blacksmithy mountain)
      (border blacksmithy city)
      (border tundra city)
      (border mountain pond)
      (border mountain blacksmithy)
      (border city blacksmithy)
      (border city tundra)
      (at king city)
      (at blacksmith blacksmithy)
      (at miner blacksmithy)
      (at lumberjack town)
      (at shopkeep town)
      (at fisher pond)
   )
  (:goal(and (at town npc)))
)