(define (problem mk4)
   (:domain magic-world)
   (:objects
      npc - character
      king blacksmith shopkeep miner lumberjack fisher - person
      goblin - minor
      gobking - major
      town forest road city mine pond mountain tundra abandonedhouse  - location
      quest sword magic enchantedsword wood water bucket ore pickaxe - object
   )
   (:init
      (border abandonedhouse road)
      (border abandonedhouse mountain)
      (border pond forest)
      (border pond town)
      (border pond city)
      (border forest mine)
      (border forest pond)
      (border town road)
      (border town mine)
      (border town pond)
      (border road abandonedhouse)
      (border road town)
      (border mine forest)
      (border mine town)
      (border tundra mountain)
      (border mountain abandonedhouse)
      (border mountain tundra)
      (border city pond)
      (at king city)
      (at blacksmith mine)
      (at miner mine)
      (at lumberjack town)
      (at shopkeep town)
      (at fisher pond)
      (at npc mine)
   )
  (:goal(and (at npc forest)))
)