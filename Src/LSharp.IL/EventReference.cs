// Copyright (c) 2020 - 2021 Faber Leonardo. All Rights Reserved. https://github.com/FaberSanZ

/*===================================================================================
	EventReference.cs
====================================================================================*/

using System;

namespace LSharp.IL
{

	public abstract class EventReference : MemberReference {

		TypeReference event_type;

		public TypeReference EventType {
			get { return event_type; }
			set { event_type = value; }
		}

		public override string FullName {
			get { return event_type.FullName + " " + MemberFullName (); }
		}

		protected EventReference (string name, TypeReference eventType)
			: base (name)
		{
			Mixin.CheckType (eventType, Mixin.Argument.eventType);
			event_type = eventType;
		}

		protected override IMemberDefinition ResolveDefinition ()
		{
			return this.Resolve ();
		}

		public new abstract EventDefinition Resolve ();
	}
}
