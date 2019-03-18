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
      (border abandonedhouse pond)
      (border abandonedhouse city)
      (border pond abandonedhouse)
      (border forest town)
      (border forest tundra)
      (border town mountain)
      (border town forest)
      (border road tundra)
      (border mine mountain)
      (border mine city)
      (border tundra forest)
      (border tundra road)
      (border mountain town)
      (border mountain mine)
      (border city abandonedhouse)
      (border city mine)
      (at king city)
      (at blacksmith mine)
      (at miner mine)
      (at lumberjack town)
      (at shopkeep town)
      (at fisher pond)
      (at npc abandonedhouse)
   )
  (:goal(and (at npc mine)))
)