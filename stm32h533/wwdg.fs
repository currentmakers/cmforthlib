\
\ @file wwdg.fs
\ @brief WWDG address block description
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief WWDG control register
\ Address offset: 0x00
\ Reset value: 0x0000007F
\

$0000007f constant WWDG_WWDG_CR_T                                   \ 7-bit counter (MSB to LSB)
$00000080 constant WWDG_WWDG_CR_WDGA                                \ Activation bit


\
\ @brief WWDG configuration register
\ Address offset: 0x04
\ Reset value: 0x0000007F
\

$0000007f constant WWDG_WWDG_CFR_W                                  \ 7-bit window value
$00000200 constant WWDG_WWDG_CFR_EWI                                \ Early wake-up interrupt enable
$00003800 constant WWDG_WWDG_CFR_WDGTB                              \ Timer base


\
\ @brief WWDG status register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant WWDG_WWDG_SR_EWIF                                \ Early wake-up interrupt flag


\
\ @brief WWDG address block description
\
$40002c00 constant WWDG_WWDG_CR   \ offset: 0x00 : WWDG control register
$40002c04 constant WWDG_WWDG_CFR  \ offset: 0x04 : WWDG configuration register
$40002c08 constant WWDG_WWDG_SR   \ offset: 0x08 : WWDG status register

