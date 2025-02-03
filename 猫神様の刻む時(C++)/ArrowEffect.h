#pragma once
#include "EffectMng.h"
#include "CameraDebug.h"
#include "CameraBase.h"

#define ARROW_EFFECT_MAX (60)
#define ROCK_MAX_NUM (5)

class ArrowEffect
{
public:
	ArrowEffect();
	~ArrowEffect();
	void Update(int Direction, int Phase, DirectX::XMFLOAT3 Pos[5], DirectX::XMFLOAT3 RockPos, bool IsEffect);
	void Draw(DirectX::XMFLOAT4X4 view, DirectX::XMFLOAT4X4 proj);
	void UpdateSelect(int EffectNo, bool IsEffect);

private:
	EffectMng* m_pEffectMng[ARROW_EFFECT_MAX];
	CameraBase* m_pCamera;
	bool m_bIsEffect[ARROW_EFFECT_MAX];
	int m_nframe[ARROW_EFFECT_MAX];
	int m_nAnimeNo[ARROW_EFFECT_MAX];
	bool m_bIsPlay[ARROW_EFFECT_MAX];
	DirectX::XMFLOAT3 m_pos[5];


};