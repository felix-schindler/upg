using Godot;

namespace untitledplantgame.Dialogue.Models;

[GlobalClass]
public partial class DialogueResponse : Resource
{
	[Export]
	public string _responseButton { get; set; }

	[Export]
	public DialogueResourceObject _responseDialogue { get; set; }
}
