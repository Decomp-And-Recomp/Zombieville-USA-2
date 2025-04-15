Shader " Library/Cull All" {
	SubShader
	{
		Tags { "Queue"="Transparent" }

		Pass
		{
			Blend SrcAlpha OneMinusSrcAlpha
			ZWrite Off
			Material
			{
				Diffuse [_Color]
			}
			Lighting Off
			SetTexture [_MainTex]
			{
				constantColor [_Color]
				Combine texture * constant
			}
		}
	}
}