(define (domain magic-world)
   (:requirements :strips :typing)
   (:types player person location minor major element)
   (:action move
      :parameters (?p - player ?l1 - location ?l2 - location)
      :precondition (and (at ?p ?l1) (border ?l1 ?l2) (not (guarded ?l2)))
      :effect (and (at ?p ?l2) (not (at ?p ?l1)))
   )
   (:action gather-wood
      :parameters (?p - player ?n - person ?l - location ?e - element)
      :precondition (and (at ?p ?l) (at ?m ?l) (wood ?e) (at ?e ?l))
      :effect (and (has-wood ?p) not (has-wood ?l))
   )
   (:action gather-ore
      :parameters (?p - player ?n - person ?l - location ?e - element)
      :precondition (and (at ?p ?l) (at ?m ?l) (ore ?e) (at ?e ?l))
      :effect (and (has-ore ?p) not (has-ore ?l))
   )
   (:action gather-water
      :parameters (?p - player ?n - person ?l - location ?e - element)
      :precondition (and (at ?p ?l) (at ?m ?l) (water ?e) (at ?e ?l))
      :effect (and (has-water ?p) not (has-water ?l))
   )
   (:action gather-fish
      :parameters (?p - player ?n - person ?l - location ?e - element)
      :precondition (and (at ?p ?l) (at ?m ?l) (fish ?e) (at ?e ?l))
      :effect (and (has-fish ?p) not (has-fish ?l))
   )
   (:action gather-fish
      :parameters (?p - player ?n - person ?l - location ?e - element)
      :precondition (and (at ?p ?l) (at ?m ?l) (fish ?e) (at ?e ?l))
      :effect (and (has-fish ?p) not (has-fish ?l))
   )
   (:action attackminor
      :parameters (?p - player ?m - minor ?l1 - location ?l2 - location)
      :precondition (and (at ?p ?l1) (at ?m ?l2) (border ?l1 ?l2) (guarded ?l2) (has-quest ?p) (has-sword ?p))
      :effect (not (at ?m ?l2) not (guarded ?l2))
   )
   (:action attackmajor
      :parameters (?p - player ?m - major ?l1 - location ?l2 - location)
      :precondition (and (at ?p ?l1) (at ?m ?l2) (border ?l1 ?l2) (guarded ?l2) (has-quest ?p) (has-enchantedsword ?p))
      :effect (and (has-gobkinghead ?p) not (at ?m ?l2) not (guarded ?l2))
   )
   (:action build-enchantedsword
      :parameters (?p - player)
      :precondition (and (has-sword ?p) (has-magic ?p))
      :effect (and (has-enchantedsword ?p) not (has-magic ?p))
   )
   (:action talk-wizard
      :parameters (?p - player ?w - person ?l - location) 
      :precondition (and (at ?p ?l) (at ?w ?l) (has-quest ?p))
      :effect (and (has-magic ?p))
   )
   (:action talk-king-again
      :parameters (?p - player ?k - person ?l - location)
      :precondition (and (at ?p ?l) (at ?k ?l) (has-gobkinghead ?p))
      :effect (and (has-complete ?p) not (has-gobkinghead ?p))
   )
   (:action talk-king
      :parameters (?p - player ?k - person ?l - location) 
      :precondition (and (at ?p ?l) (at ?k ?l))
      :effect (and (has-quest ?p))
   )
   (:action talk-blacksmith
      :parameters (?p - player ?b - person ?l - location)
      :precondition (and (at ?p ?l) (at ?b ?l) (has-quest ?p))
      :effect (and (has-sword ?p))
   )
)