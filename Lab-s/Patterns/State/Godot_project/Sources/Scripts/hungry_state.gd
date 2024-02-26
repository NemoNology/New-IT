class_name HungryState extends BotState

func run():
	#bot.sprite.material.
	var new_hungry = randi_range(bot.MV * .3, bot.MV) + bot.hungry
	if new_hungry > bot.MV:
		bot.hungry = bot.MV
	else:
		bot.hungry = new_hungry
	bot.set_state(NormalState.new(bot))


func _to_string():
	return "Трапезничаю"
