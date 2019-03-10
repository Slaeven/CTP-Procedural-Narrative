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
      (border abandonedhouse town)
      (border abandonedhouse city)
      (border pond forest)
      (border forest city)
      (border forest pond)
      (border town mountain)
      (border town abandonedhouse)
      (border road blacksmithy)
      (border blacksmithy tundra)
      (border blacksmithy road)
      (border tundra mountain)
      (border tundra blacksmithy)
      (border mountain town)
      (border mountain tundra)
      (border city abandonedhouse)
      (border city forest)
      (at king city)
      (at blacksmith blacksmithy)
      (at miner blacksmithy)
      (at lumberjack town)
      (at shopkeep town)
      (at fisher pond)
   )
  (:goal(and (has-complete npc)))
)