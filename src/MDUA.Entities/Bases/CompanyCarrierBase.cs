using System;
using System.Runtime.Serialization;
using System.ServiceModel;

using MDUA.Framework;

namespace MDUA.Entities.Bases
{
	[Serializable]
    [DataContract(Name = "CompanyCarrierBase", Namespace = "http://www.piistech.com//entities")]
	public class CompanyCarrierBase : BaseBusinessEntity
	{
	
		#region Enum Collection
		public enum Columns
		{
			Id = 0,
			CompanyId = 1,
			CarrierId = 2,
			ApiKey = 3,
			ApiSecret = 4,
			IsActive = 5
		}
		#endregion
	
		#region Constants
		public const string Property_Id = "Id";		            
		public const string Property_CompanyId = "CompanyId";		            
		public const string Property_CarrierId = "CarrierId";		            
		public const string Property_ApiKey = "ApiKey";		            
		public const string Property_ApiSecret = "ApiSecret";		            
		public const string Property_IsActive = "IsActive";		            
		#endregion
		
		#region Private Data Types
		private Int32 _Id;	            
		private Int32 _CompanyId;	            
		private Int32 _CarrierId;	            
		private String _ApiKey;	            
		private String _ApiSecret;	            
		private Boolean _IsActive;	            
		#endregion
		
		#region Properties		
		[DataMember]
		public Int32 Id
		{	
			get{ return _Id; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_Id, value, _Id);
				if (PropertyChanging(args))
				{
					_Id = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Int32 CompanyId
		{	
			get{ return _CompanyId; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_CompanyId, value, _CompanyId);
				if (PropertyChanging(args))
				{
					_CompanyId = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Int32 CarrierId
		{	
			get{ return _CarrierId; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_CarrierId, value, _CarrierId);
				if (PropertyChanging(args))
				{
					_CarrierId = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String ApiKey
		{	
			get{ return _ApiKey; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_ApiKey, value, _ApiKey);
				if (PropertyChanging(args))
				{
					_ApiKey = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public String ApiSecret
		{	
			get{ return _ApiSecret; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_ApiSecret, value, _ApiSecret);
				if (PropertyChanging(args))
				{
					_ApiSecret = value;
					PropertyChanged(args);					
				}	
			}
        }

		[DataMember]
		public Boolean IsActive
		{	
			get{ return _IsActive; }			
			set
			{
				PropertyChangingEventArgs args = new PropertyChangingEventArgs(Property_IsActive, value, _IsActive);
				if (PropertyChanging(args))
				{
					_IsActive = value;
					PropertyChanged(args);					
				}	
			}
        }

		#endregion
		
		#region Cloning Base Objects
		public  CompanyCarrierBase Clone()
		{
			CompanyCarrierBase newObj = new  CompanyCarrierBase();
			base.CloneBase(newObj);
			newObj.Id = this.Id;						
			newObj.CompanyId = this.CompanyId;						
			newObj.CarrierId = this.CarrierId;						
			newObj.ApiKey = this.ApiKey;						
			newObj.ApiSecret = this.ApiSecret;						
			newObj.IsActive = this.IsActive;						
			
			return newObj;
		}
		#endregion
		
		#region Getting object by adding value of that properties 
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue(CompanyCarrierBase.Property_Id, Id);				
			info.AddValue(CompanyCarrierBase.Property_CompanyId, CompanyId);				
			info.AddValue(CompanyCarrierBase.Property_CarrierId, CarrierId);				
			info.AddValue(CompanyCarrierBase.Property_ApiKey, ApiKey);				
			info.AddValue(CompanyCarrierBase.Property_ApiSecret, ApiSecret);				
			info.AddValue(CompanyCarrierBase.Property_IsActive, IsActive);				
		}
		#endregion

		
	}
}