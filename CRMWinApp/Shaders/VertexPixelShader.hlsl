/////////////
// GLOBALS //
/////////////
Texture2D shaderTexture;
SamplerState textureSampler
{
	Filter = MIN_MAG_MIP_LINEAR;
	AddressU = Wrap;
	AddressV = Wrap;
};

cbuffer MatrixBuffer : register(b0)
{
	matrix worldMatrix;
	matrix viewMatrix;
	matrix projectionMatrix;
	float4x4 worldViewProj;
};


//////////////
// TYPEDEFS //
//////////////
struct PixelInputType
{
	float4 position : SV_POSITION;
	float2 tex : TEXCOORD0;
};
struct VertexInputType
{
	float4 position : POSITION;
	float2 tex : TEXCOORD0;
};

////////////////////////////////////////////////////////////////////////////////
// Pixel Shader
////////////////////////////////////////////////////////////////////////////////
float4 TexturePixelShader(PixelInputType input) : SV_TARGET
{
	float4 textureColor;


	// Sample the pixel color from the texture using the sampler at this texture coordinate location.
	textureColor = shaderTexture.Sample(textureSampler,input.tex);


	return textureColor;
}

PixelInputType TextureVertexShader(VertexInputType input)
{
	PixelInputType output = (PixelInputType)0;



	// Calculate the position of the vertex against the world, view, and projection matrices.
	output.position = mul(input.position,worldViewProj);

	// Store the texture coordinates for the pixel shader.
	output.tex = input.tex;

	return output;
}