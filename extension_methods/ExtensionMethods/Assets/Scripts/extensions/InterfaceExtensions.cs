using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class InterfaceExtensions
{
	#region GameObject methods
	
	public static T GetInterface<T>(this GameObject gameObject) where T : class
	{
		return GetInterface<T>(gameObject, typeof(MonoBehaviour));
	}
	
	public static T GetInterface<T>(this GameObject gameObject, System.Type componentType) where T : class
	{
		if(!typeof(T).IsInterface)
		{
			throw new System.Exception(typeof(T).ToString() + " is not an interface");
		}
		
		Component[] components = gameObject.GetComponents(componentType);
		return getInterfaceInComponents<T>(components);
	}
	
	public static T[] GetInterfaces<T>(this GameObject gameObject) where T : class
	{
		return GetInterfaces<T>(gameObject, typeof(MonoBehaviour));
	}
	
	public static T[] GetInterfaces<T>(this GameObject gameObject, System.Type componentType) where T : class
	{
		if(!typeof(T).IsInterface)
		{
			throw new System.Exception(typeof(T).ToString() + " is not an interface");
		}
		
		Component[] components = gameObject.GetComponents(componentType);
		return getInterfacesInComponents<T>(components);		
	}
	
	public static T[] GetInterfacesInChildren<T>(this GameObject gameObject) where T : class
	{
		return GetInterfacesInChildren<T>(gameObject, typeof(MonoBehaviour));
	}
	
	public static T[] GetInterfacesInChildren<T>(this GameObject gameObject, System.Type componentType) where T : class
	{
		if(!typeof(T).IsInterface)
		{
			throw new System.Exception(typeof(T).ToString() + " is not an interface");
		}
		
		Component[] components = gameObject.GetComponentsInChildren(componentType);
		return getInterfacesInComponents<T>(components);
	}
	
	#endregion
	
	#region Component methods
	
	public static T GetInterface<T>(this Component component) where T : class
	{
		return GetInterface<T>(component, typeof(MonoBehaviour));
	}
	
	public static T GetInterface<T>(this Component component, System.Type componentType) where T : class
	{
		if(!typeof(T).IsInterface)
		{
			throw new System.Exception(typeof(T).ToString() + " is not an interface");
		}
		
		Component[] components = component.GetComponents(componentType);
		return getInterfaceInComponents<T>(components);
	}
	
	public static T[] GetInterfaces<T>(this Component component) where T : class
	{
		return GetInterfaces<T>(component, typeof(MonoBehaviour));
	}
	
	public static T[] GetInterfaces<T>(this Component component, System.Type componentType) where T : class
	{
		if(!typeof(T).IsInterface)
		{
			throw new System.Exception(typeof(T).ToString() + " is not an interface");
		}
		
		Component[] components = component.GetComponents(componentType);
		return getInterfacesInComponents<T>(components);		
	}
	
	public static T[] GetInterfacesInChildren<T>(this Component component) where T : class
	{
		return GetInterfacesInChildren<T>(component, typeof(MonoBehaviour));
	}
	
	public static T[] GetInterfacesInChildren<T>(this Component component, System.Type componentType) where T : class
	{
		if(!typeof(T).IsInterface)
		{
			throw new System.Exception(typeof(T).ToString() + " is not an interface");
		}
		
		Component[] components = component.GetComponentsInChildren(componentType);
		return getInterfacesInComponents<T>(components);
	}
	
	#endregion
	
	#region Helper methods
	
	static T getInterfaceInComponents<T>(Component[] components) where T : class
	{
		for(int i = 0; i < components.Length; i++)
		{
			Component component = components[i];
			if(component is T)
			{
				return component as T; 
			}
		}
		
		return null;
	}
	
	static T[] getInterfacesInComponents<T>(Component[] components) where T : class
	{
		List<T> foundInterfaces = new List<T>();
		for(int i = 0; i < components.Length; i++)
		{
			Component component = components[i];
			T convertedComponent = component as T;
			if(convertedComponent != null)
			{
				foundInterfaces.Add(convertedComponent);
			}
		}
		
		return foundInterfaces.ToArray();
	}
	
	#endregion
}