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
      (border abandonedhouse city)
      (border pond road)
      (border pond tundra)
      (border forest town)
      (border town tundra)
      (border town forest)
      (border road mountain)
      (border road pond)
      (border blacksmithy mountain)
      (border blacksmithy city)
      (border tundra pond)
      (border tundra town)
      (border mountain road)
      (border mountain blacksmithy)
      (border city abandonedhouse)
      (border city blacksmithy)
      (at king city)
      (at blacksmith blacksmithy)
      (at miner blacksmithy)
      (at lumberjack town)
      (at shopkeep town)
      (at fisher pond)
   )
  (:goal(and (at mountain npc)))
)