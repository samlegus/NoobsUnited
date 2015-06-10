using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.Collections;

public partial class MonoBehaviourCreationWizard : EditorWindow
{
	public abstract class StreamWritableScriptObject
	{
		public abstract void OnStreamWrite(System.IO.StreamWriter sw);
		public List<string> lines {get;set;}

		protected string comment = "";

		public void SetComment(string comment)
		{
			this.comment = "//" + comment;
		}
	}

	public class StreamWritableMethod : StreamWritableScriptObject
	{
		public StreamWritableMethod(string returnType, string name, params string[] namedArguments)
		{
			this.returnType = returnType;
			this.name = name;
			this.namedArguments = namedArguments;
			this.lines = new List<string>();

			string methodSignature = this.returnType + " " + this.name + "(";

			for(int i = 0; i < this.namedArguments.Length; ++i)
			{
				methodSignature += this.namedArguments[i];
				if(i != this.namedArguments.Length - 1 && this.namedArguments.Length > 1)
				{
					methodSignature += ", ";
				}
			}

			methodSignature += ")";
		
			lines.Add ("\t" + methodSignature);
			lines.Add ("\t{");
			lines.Add ("");
			lines.Add ("\t}");
		}

		public override void OnStreamWrite(System.IO.StreamWriter sw)
		{
			if(!System.String.IsNullOrEmpty (comment))
			{
				sw.WriteLine (comment);
			}
			foreach(string line in lines)
			{
				sw.WriteLine (line);
			}
		}

		public string returnType {get;set;}
		public string name {get;set;}
		public string [] namedArguments {get;set;}
	}

	public class StreamWritableComponent : StreamWritableScriptObject 
	{
		public StreamWritableComponent(string typeName, string propertyName)
		{
			this.typeName = typeName;
			this.lines = new List<string>();
			this.lines.Add ("\t" + typeName + " " + propertyName + "{ get { return gameObject.GetComponent<" + this.typeName + ">" + "(); } }");
			//this.lines.Add ("\t{");
			//this.lines.Add ("\t\tget { return gameObject.GetComponent<" + this.typeName + ">" + "(); }");
			//this.lines.Add ("\t}");
		}

		public override void OnStreamWrite(System.IO.StreamWriter sw)
		{
			foreach(string s in lines)
			{
				sw.WriteLine (s);
			}
		}

		public string typeName {get;set;}
	}

	public class StreamWritableProperty : StreamWritableScriptObject 
	{
		public StreamWritableProperty(string typeName, string propertyName, string propertyValue, bool isPrivate = false)
		{
			this.typeName = typeName;
			this.propertyValue = propertyValue;
			this.isPrivate = isPrivate;
			this.lines = new List<string>();

			string accessSpec = isPrivate ? "private" : "public";

			this.lines.Add ("\t" + accessSpec + " " + typeName + " " + propertyName + " { " + "get { return " + propertyValue + ";}" + " }");
			//this.lines.Add ("\t{");
			//this.lines.Add ("\t\tget { return " + propertyValue + ";}");
			//this.lines.Add ("\t}");
		}
		
		public override void OnStreamWrite(System.IO.StreamWriter sw)
		{
			foreach(string s in lines)
			{
				sw.WriteLine (s);
			}
		}

		public bool isPrivate {get;set;}
		public string typeName {get;set;}
		public string propertyValue {get;set;}
		public string propertyName {get;set;}
		//public List<string> lines {get;set;}
		//public string comment {get;set;}
	}
}