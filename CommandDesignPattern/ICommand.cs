﻿using System;
namespace CommandDesignPattern
{
	public interface ICommand
	{

		public void Execute();
		public void Undo();
	}
}

