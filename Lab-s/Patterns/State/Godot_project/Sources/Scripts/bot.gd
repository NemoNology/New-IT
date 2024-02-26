class_name Bot extends Node2D

const MV: int = 1e+4
var hungry: int = MV
var thirst: int = MV
var energy: int = MV
var state: BotState

func _ready():
	state = NormalState.new(self)
	add_child(state)

func set_state(new_state: BotState):
	remove_child(state)
	state = new_state
	add_child(state)

func _process(delta):
	hungry -= 2 * delta
	thirst -= 16 * delta
	energy -= 8 * delta
	#state.run()
