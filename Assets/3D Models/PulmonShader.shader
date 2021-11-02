Shader "Custom/PulmonShader" {
	Properties{
		_Cube("Cubemap", CUBE) = "" {}
		_MainTex("Base (RGB)", 2D) = "white" {}
		_RimStr("Rim strength", Range(0.1, 5)) = 0.78
		_SpecularStr("Specular reflection strength", Range(0, 2)) = 2
	}
		SubShader{
			Tags { "RenderType" = "Transparent" "Queue" = "Transparent" }

			CGPROGRAM
			#pragma surface surf Lambert alpha

			sampler2D _MainTex;
			samplerCUBE _Cube;
			fixed _RimStr;
			fixed _SpecularStr;
			float _Glossiness;

			struct Input {
				float2 uv_MainTex;
				float3 viewDir;
				float3 worldNormal;
				float3 worldRefl;
			};

			void surf(Input IN, inout SurfaceOutput o) {
				half4 c = tex2D(_MainTex, IN.uv_MainTex);
				o.Albedo = c.rgb;
				float3 normal = normalize(IN.worldNormal);
				float3 dir = normalize(IN.viewDir);
				float val = 1 - (abs(dot(dir, normal)));
				float rim = val * val * val * val * _RimStr;
				o.Emission = texCUBE(_Cube, IN.worldRefl).rgb * pow(rim, _RimStr) * _SpecularStr;
				o.Alpha = c.a * rim + o.Emission;

			}
			ENDCG
		}
			FallBack "Diffuse"
}
