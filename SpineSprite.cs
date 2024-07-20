using Godot;
using System;

public partial class SpineSprite : SpineSprite {
   private SpineSkeleton spineSkeleton;
   private SpineAnimationState spineSpriteAnimState;

   public override void _Ready () {
	  spineSkeleton = GetSkeleton();
	  spineSpriteAnimState = GetAnimationState();
	  spineSkeleton.SetScaleX(-1);
	  spineSpriteAnimState.SetAnimation("idle", true, 0);
	  spineSpriteAnimState.AddAnimation("run", 2, true, 0);
   }
}
