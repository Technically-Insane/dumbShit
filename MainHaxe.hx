class Main {
	public function main() {
		var Integer = 10;
		var Decimal = 10.9;
		var Text = "This is text";
		var Character = '$';

		if (Integer == 10 && Decimal > 10) {
			Text = "This is an If / Else statement";
		} else {
			Text = "Variables can be updated";
		}

		while (Integer == 10) {
			Text = "While Statements repeat as long as the condition is true";
		}

		trace("This outputs text");
	}
}
