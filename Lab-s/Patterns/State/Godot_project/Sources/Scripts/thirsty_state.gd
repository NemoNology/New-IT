class_name ThirstyState extends BotState

func run():
	var new_thirst = randi_range(.6 * bot.MV, .9 * bot.MV)+ bot.thirst
	if new_thirst > bot.MV:
		bot.thirst = bot.MV
	else:
		bot.thirst = new_thirst
	bot.set_state(NormalState.new(bot))


func _to_string():
	return "Пью"
