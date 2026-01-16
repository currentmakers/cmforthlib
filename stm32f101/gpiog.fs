\
\ @file gpiog.fs
\ @brief General purpose I/O
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Port configuration register low (GPIOn_CRL)
\ Address offset: 0x00
\ Reset value: 0x44444444
\

$00000003 constant GPIOG_CRL_MODE0                                  \ Port n.0 mode bits
$0000000c constant GPIOG_CRL_CNF0                                   \ Port n.0 configuration bits
$00000030 constant GPIOG_CRL_MODE1                                  \ Port n.1 mode bits
$000000c0 constant GPIOG_CRL_CNF1                                   \ Port n.1 configuration bits
$00000300 constant GPIOG_CRL_MODE2                                  \ Port n.2 mode bits
$00000c00 constant GPIOG_CRL_CNF2                                   \ Port n.2 configuration bits
$00003000 constant GPIOG_CRL_MODE3                                  \ Port n.3 mode bits
$0000c000 constant GPIOG_CRL_CNF3                                   \ Port n.3 configuration bits
$00030000 constant GPIOG_CRL_MODE4                                  \ Port n.4 mode bits
$000c0000 constant GPIOG_CRL_CNF4                                   \ Port n.4 configuration bits
$00300000 constant GPIOG_CRL_MODE5                                  \ Port n.5 mode bits
$00c00000 constant GPIOG_CRL_CNF5                                   \ Port n.5 configuration bits
$03000000 constant GPIOG_CRL_MODE6                                  \ Port n.6 mode bits
$0c000000 constant GPIOG_CRL_CNF6                                   \ Port n.6 configuration bits
$30000000 constant GPIOG_CRL_MODE7                                  \ Port n.7 mode bits
$c0000000 constant GPIOG_CRL_CNF7                                   \ Port n.7 configuration bits


\
\ @brief Port configuration register high (GPIOn_CRL)
\ Address offset: 0x04
\ Reset value: 0x44444444
\

$00000003 constant GPIOG_CRH_MODE8                                  \ Port n.8 mode bits
$0000000c constant GPIOG_CRH_CNF8                                   \ Port n.8 configuration bits
$00000030 constant GPIOG_CRH_MODE9                                  \ Port n.9 mode bits
$000000c0 constant GPIOG_CRH_CNF9                                   \ Port n.9 configuration bits
$00000300 constant GPIOG_CRH_MODE10                                 \ Port n.10 mode bits
$00000c00 constant GPIOG_CRH_CNF10                                  \ Port n.10 configuration bits
$00003000 constant GPIOG_CRH_MODE11                                 \ Port n.11 mode bits
$0000c000 constant GPIOG_CRH_CNF11                                  \ Port n.11 configuration bits
$00030000 constant GPIOG_CRH_MODE12                                 \ Port n.12 mode bits
$000c0000 constant GPIOG_CRH_CNF12                                  \ Port n.12 configuration bits
$00300000 constant GPIOG_CRH_MODE13                                 \ Port n.13 mode bits
$00c00000 constant GPIOG_CRH_CNF13                                  \ Port n.13 configuration bits
$03000000 constant GPIOG_CRH_MODE14                                 \ Port n.14 mode bits
$0c000000 constant GPIOG_CRH_CNF14                                  \ Port n.14 configuration bits
$30000000 constant GPIOG_CRH_MODE15                                 \ Port n.15 mode bits
$c0000000 constant GPIOG_CRH_CNF15                                  \ Port n.15 configuration bits


\
\ @brief Port input data register (GPIOn_IDR)
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant GPIOG_IDR_IDR0                                   \ Port input data
$00000002 constant GPIOG_IDR_IDR1                                   \ Port input data
$00000004 constant GPIOG_IDR_IDR2                                   \ Port input data
$00000008 constant GPIOG_IDR_IDR3                                   \ Port input data
$00000010 constant GPIOG_IDR_IDR4                                   \ Port input data
$00000020 constant GPIOG_IDR_IDR5                                   \ Port input data
$00000040 constant GPIOG_IDR_IDR6                                   \ Port input data
$00000080 constant GPIOG_IDR_IDR7                                   \ Port input data
$00000100 constant GPIOG_IDR_IDR8                                   \ Port input data
$00000200 constant GPIOG_IDR_IDR9                                   \ Port input data
$00000400 constant GPIOG_IDR_IDR10                                  \ Port input data
$00000800 constant GPIOG_IDR_IDR11                                  \ Port input data
$00001000 constant GPIOG_IDR_IDR12                                  \ Port input data
$00002000 constant GPIOG_IDR_IDR13                                  \ Port input data
$00004000 constant GPIOG_IDR_IDR14                                  \ Port input data
$00008000 constant GPIOG_IDR_IDR15                                  \ Port input data


\
\ @brief Port output data register (GPIOn_ODR)
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant GPIOG_ODR_ODR0                                   \ Port output data
$00000002 constant GPIOG_ODR_ODR1                                   \ Port output data
$00000004 constant GPIOG_ODR_ODR2                                   \ Port output data
$00000008 constant GPIOG_ODR_ODR3                                   \ Port output data
$00000010 constant GPIOG_ODR_ODR4                                   \ Port output data
$00000020 constant GPIOG_ODR_ODR5                                   \ Port output data
$00000040 constant GPIOG_ODR_ODR6                                   \ Port output data
$00000080 constant GPIOG_ODR_ODR7                                   \ Port output data
$00000100 constant GPIOG_ODR_ODR8                                   \ Port output data
$00000200 constant GPIOG_ODR_ODR9                                   \ Port output data
$00000400 constant GPIOG_ODR_ODR10                                  \ Port output data
$00000800 constant GPIOG_ODR_ODR11                                  \ Port output data
$00001000 constant GPIOG_ODR_ODR12                                  \ Port output data
$00002000 constant GPIOG_ODR_ODR13                                  \ Port output data
$00004000 constant GPIOG_ODR_ODR14                                  \ Port output data
$00008000 constant GPIOG_ODR_ODR15                                  \ Port output data


\
\ @brief Port bit set/reset register (GPIOn_BSRR)
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant GPIOG_BSRR_BS0                                   \ Set bit 0
$00000002 constant GPIOG_BSRR_BS1                                   \ Set bit 1
$00000004 constant GPIOG_BSRR_BS2                                   \ Set bit 1
$00000008 constant GPIOG_BSRR_BS3                                   \ Set bit 3
$00000010 constant GPIOG_BSRR_BS4                                   \ Set bit 4
$00000020 constant GPIOG_BSRR_BS5                                   \ Set bit 5
$00000040 constant GPIOG_BSRR_BS6                                   \ Set bit 6
$00000080 constant GPIOG_BSRR_BS7                                   \ Set bit 7
$00000100 constant GPIOG_BSRR_BS8                                   \ Set bit 8
$00000200 constant GPIOG_BSRR_BS9                                   \ Set bit 9
$00000400 constant GPIOG_BSRR_BS10                                  \ Set bit 10
$00000800 constant GPIOG_BSRR_BS11                                  \ Set bit 11
$00001000 constant GPIOG_BSRR_BS12                                  \ Set bit 12
$00002000 constant GPIOG_BSRR_BS13                                  \ Set bit 13
$00004000 constant GPIOG_BSRR_BS14                                  \ Set bit 14
$00008000 constant GPIOG_BSRR_BS15                                  \ Set bit 15
$00010000 constant GPIOG_BSRR_BR0                                   \ Reset bit 0
$00020000 constant GPIOG_BSRR_BR1                                   \ Reset bit 1
$00040000 constant GPIOG_BSRR_BR2                                   \ Reset bit 2
$00080000 constant GPIOG_BSRR_BR3                                   \ Reset bit 3
$00100000 constant GPIOG_BSRR_BR4                                   \ Reset bit 4
$00200000 constant GPIOG_BSRR_BR5                                   \ Reset bit 5
$00400000 constant GPIOG_BSRR_BR6                                   \ Reset bit 6
$00800000 constant GPIOG_BSRR_BR7                                   \ Reset bit 7
$01000000 constant GPIOG_BSRR_BR8                                   \ Reset bit 8
$02000000 constant GPIOG_BSRR_BR9                                   \ Reset bit 9
$04000000 constant GPIOG_BSRR_BR10                                  \ Reset bit 10
$08000000 constant GPIOG_BSRR_BR11                                  \ Reset bit 11
$10000000 constant GPIOG_BSRR_BR12                                  \ Reset bit 12
$20000000 constant GPIOG_BSRR_BR13                                  \ Reset bit 13
$40000000 constant GPIOG_BSRR_BR14                                  \ Reset bit 14
$80000000 constant GPIOG_BSRR_BR15                                  \ Reset bit 15


\
\ @brief Port bit reset register (GPIOn_BRR)
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant GPIOG_BRR_BR0                                    \ Reset bit 0
$00000002 constant GPIOG_BRR_BR1                                    \ Reset bit 1
$00000004 constant GPIOG_BRR_BR2                                    \ Reset bit 1
$00000008 constant GPIOG_BRR_BR3                                    \ Reset bit 3
$00000010 constant GPIOG_BRR_BR4                                    \ Reset bit 4
$00000020 constant GPIOG_BRR_BR5                                    \ Reset bit 5
$00000040 constant GPIOG_BRR_BR6                                    \ Reset bit 6
$00000080 constant GPIOG_BRR_BR7                                    \ Reset bit 7
$00000100 constant GPIOG_BRR_BR8                                    \ Reset bit 8
$00000200 constant GPIOG_BRR_BR9                                    \ Reset bit 9
$00000400 constant GPIOG_BRR_BR10                                   \ Reset bit 10
$00000800 constant GPIOG_BRR_BR11                                   \ Reset bit 11
$00001000 constant GPIOG_BRR_BR12                                   \ Reset bit 12
$00002000 constant GPIOG_BRR_BR13                                   \ Reset bit 13
$00004000 constant GPIOG_BRR_BR14                                   \ Reset bit 14
$00008000 constant GPIOG_BRR_BR15                                   \ Reset bit 15


\
\ @brief Port configuration lock register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant GPIOG_LCKR_LCK0                                  \ Port A Lock bit 0
$00000002 constant GPIOG_LCKR_LCK1                                  \ Port A Lock bit 1
$00000004 constant GPIOG_LCKR_LCK2                                  \ Port A Lock bit 2
$00000008 constant GPIOG_LCKR_LCK3                                  \ Port A Lock bit 3
$00000010 constant GPIOG_LCKR_LCK4                                  \ Port A Lock bit 4
$00000020 constant GPIOG_LCKR_LCK5                                  \ Port A Lock bit 5
$00000040 constant GPIOG_LCKR_LCK6                                  \ Port A Lock bit 6
$00000080 constant GPIOG_LCKR_LCK7                                  \ Port A Lock bit 7
$00000100 constant GPIOG_LCKR_LCK8                                  \ Port A Lock bit 8
$00000200 constant GPIOG_LCKR_LCK9                                  \ Port A Lock bit 9
$00000400 constant GPIOG_LCKR_LCK10                                 \ Port A Lock bit 10
$00000800 constant GPIOG_LCKR_LCK11                                 \ Port A Lock bit 11
$00001000 constant GPIOG_LCKR_LCK12                                 \ Port A Lock bit 12
$00002000 constant GPIOG_LCKR_LCK13                                 \ Port A Lock bit 13
$00004000 constant GPIOG_LCKR_LCK14                                 \ Port A Lock bit 14
$00008000 constant GPIOG_LCKR_LCK15                                 \ Port A Lock bit 15
$00010000 constant GPIOG_LCKR_LCKK                                  \ Lock key


\
\ @brief General purpose I/O
\
$40012000 constant GPIOG_CRL      \ offset: 0x00 : Port configuration register low (GPIOn_CRL)
$40012004 constant GPIOG_CRH      \ offset: 0x04 : Port configuration register high (GPIOn_CRL)
$40012008 constant GPIOG_IDR      \ offset: 0x08 : Port input data register (GPIOn_IDR)
$4001200c constant GPIOG_ODR      \ offset: 0x0C : Port output data register (GPIOn_ODR)
$40012010 constant GPIOG_BSRR     \ offset: 0x10 : Port bit set/reset register (GPIOn_BSRR)
$40012014 constant GPIOG_BRR      \ offset: 0x14 : Port bit reset register (GPIOn_BRR)
$40012018 constant GPIOG_LCKR     \ offset: 0x18 : Port configuration lock register

