sampler uImage0 : register(s0);
sampler uImage1 : register(s1);
sampler uImage2 : register(s2);
sampler uImage3 : register(s3);
float3 uColor;
float3 uSecondaryColor;
float2 uScreenResolution;
float2 uScreenPosition;
float2 uTargetPosition;
float2 uDirection;
float uOpacity;
float uTime;
float uIntensity;
float uProgress;
float2 uImageSize1;
float2 uImageSize2;
float2 uImageSize3;
float2 uImageOffset;
float uSaturation;
float4 uSourceRect;
float2 uZoom;

float4 RainVignette(float4 src : COLOR0, float2 uv : TEXCOORD0) : COLOR0 {

    float2 coord = uv;
    coord.x -= 0.5;
    coord.y -= 0.5;

    float vignette = length(coord);
    vignette += 0.12;
    vignette = smoothstep(0.6, 0.5, vignette);

    src = float4(src.r,src.g, src.b, vignette);
    return src;
}
technique Technique3 {
    pass RainVignette {
        PixelShader = compile ps_2_0 RainVignette();
    }
}