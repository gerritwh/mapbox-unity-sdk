﻿namespace Mapbox.Unity.Map
{
	using System;
	[Serializable]
	public class MapPlacementOptions
	{
		public MapVisualizationType visualizationType;
		public MapPlacementType placementType;
		//public MapStreamingType streamingType;


		public IMapPlacementStrategy placementStrategy;
	}
}