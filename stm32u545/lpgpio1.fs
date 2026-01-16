\
\ @file lpgpio1.fs
\ @brief LPGPIO1
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief LPGPIO port mode register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LPGPIO1_LPGPIO_MODER_MODE0                       \ MODE0
$00000002 constant LPGPIO1_LPGPIO_MODER_MODE1                       \ MODE1
$00000004 constant LPGPIO1_LPGPIO_MODER_MODE2                       \ MODE2
$00000008 constant LPGPIO1_LPGPIO_MODER_MODE3                       \ MODE3
$00000010 constant LPGPIO1_LPGPIO_MODER_MODE4                       \ MODE4
$00000020 constant LPGPIO1_LPGPIO_MODER_MODE5                       \ MODE5
$00000040 constant LPGPIO1_LPGPIO_MODER_MODE6                       \ MODE6
$00000080 constant LPGPIO1_LPGPIO_MODER_MODE7                       \ MODE7
$00000100 constant LPGPIO1_LPGPIO_MODER_MODE8                       \ MODE8
$00000200 constant LPGPIO1_LPGPIO_MODER_MODE9                       \ MODE9
$00000400 constant LPGPIO1_LPGPIO_MODER_MODE10                      \ MODE10
$00000800 constant LPGPIO1_LPGPIO_MODER_MODE11                      \ MODE11
$00001000 constant LPGPIO1_LPGPIO_MODER_MODE12                      \ MODE12
$00002000 constant LPGPIO1_LPGPIO_MODER_MODE13                      \ MODE13
$00004000 constant LPGPIO1_LPGPIO_MODER_MODE14                      \ MODE14
$00008000 constant LPGPIO1_LPGPIO_MODER_MODE15                      \ MODE15


\
\ @brief LPGPIO port input data register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant LPGPIO1_LPGPIO_IDR_ID0                           \ ID0
$00000002 constant LPGPIO1_LPGPIO_IDR_ID1                           \ ID1
$00000004 constant LPGPIO1_LPGPIO_IDR_ID2                           \ ID2
$00000008 constant LPGPIO1_LPGPIO_IDR_ID3                           \ ID3
$00000010 constant LPGPIO1_LPGPIO_IDR_ID4                           \ ID4
$00000020 constant LPGPIO1_LPGPIO_IDR_ID5                           \ ID5
$00000040 constant LPGPIO1_LPGPIO_IDR_ID6                           \ ID6
$00000080 constant LPGPIO1_LPGPIO_IDR_ID7                           \ ID7
$00000100 constant LPGPIO1_LPGPIO_IDR_ID8                           \ ID8
$00000200 constant LPGPIO1_LPGPIO_IDR_ID9                           \ ID9
$00000400 constant LPGPIO1_LPGPIO_IDR_ID10                          \ ID10
$00000800 constant LPGPIO1_LPGPIO_IDR_ID11                          \ ID11
$00001000 constant LPGPIO1_LPGPIO_IDR_ID12                          \ ID12
$00002000 constant LPGPIO1_LPGPIO_IDR_ID13                          \ ID13
$00004000 constant LPGPIO1_LPGPIO_IDR_ID14                          \ ID14
$00008000 constant LPGPIO1_LPGPIO_IDR_ID15                          \ ID15


\
\ @brief LPGPIO port output data register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant LPGPIO1_LPGPIO_ODR_OD0                           \ OD0
$00000002 constant LPGPIO1_LPGPIO_ODR_OD1                           \ OD1
$00000004 constant LPGPIO1_LPGPIO_ODR_OD2                           \ OD2
$00000008 constant LPGPIO1_LPGPIO_ODR_OD3                           \ OD3
$00000010 constant LPGPIO1_LPGPIO_ODR_OD4                           \ OD4
$00000020 constant LPGPIO1_LPGPIO_ODR_OD5                           \ OD5
$00000040 constant LPGPIO1_LPGPIO_ODR_OD6                           \ OD6
$00000080 constant LPGPIO1_LPGPIO_ODR_OD7                           \ OD7
$00000100 constant LPGPIO1_LPGPIO_ODR_OD8                           \ OD8
$00000200 constant LPGPIO1_LPGPIO_ODR_OD9                           \ OD9
$00000400 constant LPGPIO1_LPGPIO_ODR_OD10                          \ OD10
$00000800 constant LPGPIO1_LPGPIO_ODR_OD11                          \ OD11
$00001000 constant LPGPIO1_LPGPIO_ODR_OD12                          \ OD12
$00002000 constant LPGPIO1_LPGPIO_ODR_OD13                          \ OD13
$00004000 constant LPGPIO1_LPGPIO_ODR_OD14                          \ OD14
$00008000 constant LPGPIO1_LPGPIO_ODR_OD15                          \ OD15


\
\ @brief LPGPIO port bit set/reset register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant LPGPIO1_LPGPIO_BSRR_BS0                          \ BS0
$00000002 constant LPGPIO1_LPGPIO_BSRR_BS1                          \ BS1
$00000004 constant LPGPIO1_LPGPIO_BSRR_BS2                          \ BS2
$00000008 constant LPGPIO1_LPGPIO_BSRR_BS3                          \ BS3
$00000010 constant LPGPIO1_LPGPIO_BSRR_BS4                          \ BS4
$00000020 constant LPGPIO1_LPGPIO_BSRR_BS5                          \ BS5
$00000040 constant LPGPIO1_LPGPIO_BSRR_BS6                          \ BS6
$00000080 constant LPGPIO1_LPGPIO_BSRR_BS7                          \ BS7
$00000100 constant LPGPIO1_LPGPIO_BSRR_BS8                          \ BS8
$00000200 constant LPGPIO1_LPGPIO_BSRR_BS9                          \ BS9
$00000400 constant LPGPIO1_LPGPIO_BSRR_BS10                         \ BS10
$00000800 constant LPGPIO1_LPGPIO_BSRR_BS11                         \ BS11
$00001000 constant LPGPIO1_LPGPIO_BSRR_BS12                         \ BS12
$00002000 constant LPGPIO1_LPGPIO_BSRR_BS13                         \ BS13
$00004000 constant LPGPIO1_LPGPIO_BSRR_BS14                         \ BS14
$00008000 constant LPGPIO1_LPGPIO_BSRR_BS15                         \ BS15
$00010000 constant LPGPIO1_LPGPIO_BSRR_BR0                          \ BR0
$00020000 constant LPGPIO1_LPGPIO_BSRR_BR1                          \ BR1
$00040000 constant LPGPIO1_LPGPIO_BSRR_BR2                          \ BR2
$00080000 constant LPGPIO1_LPGPIO_BSRR_BR3                          \ BR3
$00100000 constant LPGPIO1_LPGPIO_BSRR_BR4                          \ BR4
$00200000 constant LPGPIO1_LPGPIO_BSRR_BR5                          \ BR5
$00400000 constant LPGPIO1_LPGPIO_BSRR_BR6                          \ BR6
$00800000 constant LPGPIO1_LPGPIO_BSRR_BR7                          \ BR7
$01000000 constant LPGPIO1_LPGPIO_BSRR_BR8                          \ BR8
$02000000 constant LPGPIO1_LPGPIO_BSRR_BR9                          \ BR9
$04000000 constant LPGPIO1_LPGPIO_BSRR_BR10                         \ BR10
$08000000 constant LPGPIO1_LPGPIO_BSRR_BR11                         \ BR11
$10000000 constant LPGPIO1_LPGPIO_BSRR_BR12                         \ BR12
$20000000 constant LPGPIO1_LPGPIO_BSRR_BR13                         \ BR13
$40000000 constant LPGPIO1_LPGPIO_BSRR_BR14                         \ BR14
$80000000 constant LPGPIO1_LPGPIO_BSRR_BR15                         \ BR15


\
\ @brief LPGPIO port bit reset register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant LPGPIO1_LPGPIO_BRR_BR0                           \ BR0
$00000002 constant LPGPIO1_LPGPIO_BRR_BR1                           \ BR1
$00000004 constant LPGPIO1_LPGPIO_BRR_BR2                           \ BR2
$00000008 constant LPGPIO1_LPGPIO_BRR_BR3                           \ BR3
$00000010 constant LPGPIO1_LPGPIO_BRR_BR4                           \ BR4
$00000020 constant LPGPIO1_LPGPIO_BRR_BR5                           \ BR5
$00000040 constant LPGPIO1_LPGPIO_BRR_BR6                           \ BR6
$00000080 constant LPGPIO1_LPGPIO_BRR_BR7                           \ BR7
$00000100 constant LPGPIO1_LPGPIO_BRR_BR8                           \ BR8
$00000200 constant LPGPIO1_LPGPIO_BRR_BR9                           \ BR9
$00000400 constant LPGPIO1_LPGPIO_BRR_BR10                          \ BR10
$00000800 constant LPGPIO1_LPGPIO_BRR_BR11                          \ BR11
$00001000 constant LPGPIO1_LPGPIO_BRR_BR12                          \ BR12
$00002000 constant LPGPIO1_LPGPIO_BRR_BR13                          \ BR13
$00004000 constant LPGPIO1_LPGPIO_BRR_BR14                          \ BR14
$00008000 constant LPGPIO1_LPGPIO_BRR_BR15                          \ BR15


\
\ @brief LPGPIO1
\
$46020000 constant LPGPIO1_LPGPIO_MODER  \ offset: 0x00 : LPGPIO port mode register
$46020010 constant LPGPIO1_LPGPIO_IDR  \ offset: 0x10 : LPGPIO port input data register
$46020014 constant LPGPIO1_LPGPIO_ODR  \ offset: 0x14 : LPGPIO port output data register
$46020018 constant LPGPIO1_LPGPIO_BSRR  \ offset: 0x18 : LPGPIO port bit set/reset register
$46020028 constant LPGPIO1_LPGPIO_BRR  \ offset: 0x28 : LPGPIO port bit reset register

