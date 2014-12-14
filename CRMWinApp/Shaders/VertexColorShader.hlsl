/////////////
// GLOBALS //
/////////////

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
	float4 Color : COLOR;
};
struct VertexInputType
{
	float4 position : POSITION;
	float4 Color: COLOR;
};

////////////////////////////////////////////////////////////////////////////////
// Pixel Shader
////////////////////////////////////////////////////////////////////////////////
float4 TCSP(PixelInputType input) : SV_TARGET
{
	return input.Color;
}

PixelInputType TCSV(VertexInputType input)
{
	PixelInputType output = (PixelInputType)0;



	// Calculate the position of the vertex against the world, view, and projection matrices.
	output.position = mul(input.position,worldViewProj);

	output.Color = input.Color;

	return output;
}