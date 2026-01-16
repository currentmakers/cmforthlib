\
\ @file otg_fs_pwrclk.fs
\ @brief USB on the go full speed
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief OTG_FS power and clock gating control register (OTG_FS_PCGCCTL)
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant OTG_FS_PWRCLK_FS_PCGCCTL_STPPCLK                 \ Stop PHY clock
$00000002 constant OTG_FS_PWRCLK_FS_PCGCCTL_GATEHCLK                \ Gate HCLK
$00000010 constant OTG_FS_PWRCLK_FS_PCGCCTL_PHYSUSP                 \ PHY Suspended


\
\ @brief USB on the go full speed
\
$50000e00 constant OTG_FS_PWRCLK_FS_PCGCCTL  \ offset: 0x00 : OTG_FS power and clock gating control register (OTG_FS_PCGCCTL)

