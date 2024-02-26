class_name BotState extends Node

var bot: Bot
var timer: Timer = Timer.new()


func _init(init_bot: Bot):
	bot = init_bot
	timer.wait_time = 1
	timer.timeout.connect(run)
	timer.autostart = true
	add_child(timer)


func set_state(newState: BotState):
	bot.set_state(newState)


func run():
	assert(false, "Not implemented run method in %s" % self)


func _exit_tree():
	queue_free()


func _to_string():
	return "Состояние бота"
