Shader "My Shaders/SelfIllumBG" {
Properties {
[PerRendererData]  _MainTex ("Sprite Texture", 2D) = "white" { }
 _Color ("Tint", Color) = (1.000000,1.000000,1.000000,1.000000)
[MaterialToggle]  PixelSnap ("Pixel snap", Float) = 0.000000
}
	SubShader
	{
		Pass
		{
			ZWrite Off
			Lighting Off
			SetTexture [_MainTex]
			{
				constantColor [_Color]
				Combine texture * constant
			}
		}
	}
}