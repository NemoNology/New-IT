extends Control

@export var bot_node_path: NodePath = "."
var bot: Bot
var state_output: Label
var hunger_output: ProgressBar
var thirst_output: ProgressBar
var energy_output: ProgressBar

func _ready():
	var bot_node = get_node_or_null(bot_node_path)
	assert(bot_node != null, "Invalid path to bot node in %s" % self)
	bot = bot_node
	state_output = get_node("MarginContainer/GridContainer/State value")
	hunger_output = get_node("MarginContainer/GridContainer/Hunger value")
	thirst_output = get_node("MarginContainer/GridContainer/Thirst value")
	energy_output = get_node("MarginContainer/GridContainer/Energy value")
	hunger_output.max_value = bot.MV
	thirst_output.max_value = bot.MV
	energy_output.max_value = bot.MV
	var step = bot.MV * .01
	energy_output.step = step
	thirst_output.step = step
	energy_output.step = step
	

func _process(delta):
	state_output.text = str(bot.state).to_lower()
	hunger_output.value = bot.hungry
	thirst_output.value = bot.thirst
	energy_output.value = bot.energy
