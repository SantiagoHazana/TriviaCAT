﻿//Version 1.65 (10.08.2016)

using System;
using UnityEngine;

namespace TriviaQuizGame.Types
{
	[Serializable]
	public class Answer
	{
		[Tooltip("The answer to a question")]
		public string answer;

		[Tooltip("An image that accompanies the answer. You can leave this empty if you don't want an image")]
		public Sprite image;

		#if !UNITY_ANDROID && !UNITY_IOS && !UNITY_BLACKBERRY && !UNITY_WP8 && !UNITY_WEBGL
		[Tooltip("A video that accompanies the answer. You can leave this empty if you don't want a video")]
		internal MovieTexture video;
		#endif

		[Tooltip("This answer is correct")]
		public bool isCorrect = false;
	}
}
