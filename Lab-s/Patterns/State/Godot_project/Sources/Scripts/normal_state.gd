class_name NormalState extends BotState

func run():	
	if bot.energy < .2 * bot.MV:
		bot.set_state(SleppyState.new(bot))
	elif bot.hungry < .5 * bot.MV:
		bot.set_state(HungryState.new(bot))
	elif bot.thirst < .5 * bot.MV:
		bot.set_state(ThirstyState.new(bot))
	else:
		bot.set_state(NormalState.new(bot))


func _to_string():
	return "Отдыхаю, хожу-брожу.."
