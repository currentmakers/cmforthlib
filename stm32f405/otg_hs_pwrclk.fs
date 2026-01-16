\
\ @file otg_hs_pwrclk.fs
\ @brief USB on the go high speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Power and clock gating control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant OTG_HS_PWRCLK_OTG_HS_PCGCR_STPPCLK               \ Stop PHY clock
$00000002 constant OTG_HS_PWRCLK_OTG_HS_PCGCR_GATEHCLK              \ Gate HCLK
$00000010 constant OTG_HS_PWRCLK_OTG_HS_PCGCR_PHYSUSP               \ PHY suspended


\
\ @brief USB on the go high speed
\
$40040e00 constant OTG_HS_PWRCLK_OTG_HS_PCGCR  \ offset: 0x00 : Power and clock gating control register

