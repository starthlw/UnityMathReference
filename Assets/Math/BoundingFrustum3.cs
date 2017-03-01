﻿using System;
using System.Runtime.InteropServices;

namespace UnityMathReference
{
	public enum ContainmentTypes
	{
		Contains,
		Intersects,
		Disjoint
	}

	[StructLayout(LayoutKind.Sequential)]
	public class BoundingFrustum3
	{
		#region Properties
		public Plane3 left, right, bottom, top, near, far;
		public Mat4 matrix;
		#endregion

		#region Constructors
		public BoundingFrustum3(Mat4 matrix)
		{
			
		}
		#endregion

		#region Methods
		public ContainmentTypes Contains(BoundingBox3 boundingBox)
		{
			throw new NotImplementedException();
		}

		public static void Contains(ref BoundingFrustum3 boundingFrustum, ref BoundingBox3 boundingBox, out ContainmentTypes result)
		{
			throw new NotImplementedException();
		}

		public ContainmentTypes Contains(BoundingSphere3 boundingSphere)
		{
			throw new NotImplementedException();
		}

		public static void Contains(ref BoundingFrustum3 boundingFrustum, ref BoundingSphere3 boundingSphere, out ContainmentTypes result)
		{
			throw new NotImplementedException();
		}

		public ContainmentTypes Contains(Vec3 point)
		{
			throw new NotImplementedException();
		}

		public static void Contains(ref BoundingFrustum3 boundingFrustum, ref Vec3 point, out ContainmentTypes result)
		{
			throw new NotImplementedException();
		}

		public ContainmentTypes Contains(BoundingFrustum3 boundingFrustum)
		{
			throw new NotImplementedException();
		}

		public static void Contains(ref BoundingFrustum3 boundingFrustum1, ref BoundingFrustum3 boundingFrustum2, out ContainmentTypes result)
		{
			throw new NotImplementedException();
		}

		public bool Intersects(BoundingBox3 boundingBox)
		{
			throw new NotImplementedException();
		}

		public static void Intersects(ref BoundingFrustum3 boundingFrustum, ref BoundingBox3 boundingBox, out bool result)
		{
			throw new NotImplementedException();
		}

		public bool Intersects(BoundingSphere3 boundingSphere)
		{
			throw new NotImplementedException();
		}

		public static void Intersects(ref BoundingFrustum3 boundingFrustum, ref BoundingSphere3 boundingSphere, out bool result)
		{
			throw new NotImplementedException();
		}

		public bool Intersects(Vec3 point)
		{
			throw new NotImplementedException();
		}

		public static void Intersects(ref BoundingFrustum3 boundingFrustum, ref Vec3 point, out bool result)
		{
			throw new NotImplementedException();
		}

		public bool Intersects(BoundingFrustum3 boundingFrustum)
		{
			throw new NotImplementedException();
		}

		public static void Intersects(ref BoundingFrustum3 boundingFrustum1, ref BoundingFrustum3 boundingFrustum2, out bool result)
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}