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
      (border abandonedhouse mountain)
      (border pond road)
      (border pond tundra)
      (border forest mountain)
      (border forest city)
      (border town mine)
      (border road abandonedhouse)
      (border road pond)
      (border mine city)
      (border mine town)
      (border tundra pond)
      (border mountain abandonedhouse)
      (border mountain forest)
      (border city forest)
      (border city mine)
      (at king city)
      (at blacksmith mine)
      (at miner mine)
      (at lumberjack town)
      (at shopkeep town)
      (at fisher pond)
   )
  (:goal(and (at road npc)))
)