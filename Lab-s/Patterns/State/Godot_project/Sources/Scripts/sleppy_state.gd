class_name SleppyState extends BotState

func run():
	bot.energy = bot.MV
	bot.set_state(NormalState.new(bot))


func _to_string():
	return "Сплю"
