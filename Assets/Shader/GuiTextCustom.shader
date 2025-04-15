Shader "GUI/Text Shader Z-Write" {
Properties {
 _MainTex ("Font Texture", 2D) = "white" { }
 _Color ("Text Color", Color) = (1.000000,1.000000,1.000000,1.000000)
}
	SubShader
	{
		Tags { "Queue"="Transparent" }

		Pass
		{
			ZWrite On
			Blend SrcAlpha OneMinusSrcAlpha
			Material
			{
				Diffuse [_Color]
			}
			Lighting Off
			SetTexture [_MainTex]
			{
				constantColor [_Color]
				Combine texture * primary DOUBLE, texture * constant
			}
		}
	}
}