\
\ @file etzpc.fs
\ @brief ETZPC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief ETZPC ROM secure size definition
\ Address offset: 0x00
\ Reset value: 0x000003FF
\

$000003ff constant ETZPC_ETZPC_TZMA0_SIZE_R0SIZE                    \ R0SIZE
$80000000 constant ETZPC_ETZPC_TZMA0_SIZE_LOCK                      \ LOCK


\
\ @brief ETZPC RAM secure size definition
\ Address offset: 0x04
\ Reset value: 0x000003FF
\

$000003ff constant ETZPC_ETZPC_TZMA1_SIZE_R0SIZE                    \ R0SIZE
$80000000 constant ETZPC_ETZPC_TZMA1_SIZE_LOCK                      \ LOCK


\
\ @brief Register reset values
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000003 constant ETZPC_ETZPC_DECPROT0_DECPROT0                    \ DECPROT0
$0000000c constant ETZPC_ETZPC_DECPROT0_DECPROT1                    \ DECPROT1
$00000030 constant ETZPC_ETZPC_DECPROT0_DECPROT2                    \ DECPROT2
$000000c0 constant ETZPC_ETZPC_DECPROT0_DECPROT3                    \ DECPROT3
$00000300 constant ETZPC_ETZPC_DECPROT0_DECPROT4                    \ DECPROT4
$00000c00 constant ETZPC_ETZPC_DECPROT0_DECPROT5                    \ DECPROT5
$00003000 constant ETZPC_ETZPC_DECPROT0_DECPROT6                    \ DECPROT6
$0000c000 constant ETZPC_ETZPC_DECPROT0_DECPROT7                    \ DECPROT7
$00030000 constant ETZPC_ETZPC_DECPROT0_DECPROT8                    \ DECPROT8
$000c0000 constant ETZPC_ETZPC_DECPROT0_DECPROT9                    \ DECPROT9
$00300000 constant ETZPC_ETZPC_DECPROT0_DECPROT10                   \ DECPROT10
$00c00000 constant ETZPC_ETZPC_DECPROT0_DECPROT11                   \ DECPROT11
$03000000 constant ETZPC_ETZPC_DECPROT0_DECPROT12                   \ DECPROT12
$0c000000 constant ETZPC_ETZPC_DECPROT0_DECPROT13                   \ DECPROT13
$30000000 constant ETZPC_ETZPC_DECPROT0_DECPROT14                   \ DECPROT14
$c0000000 constant ETZPC_ETZPC_DECPROT0_DECPROT15                   \ DECPROT15


\
\ @brief Register reset values
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000003 constant ETZPC_ETZPC_DECPROT1_DECPROT0                    \ DECPROT0
$0000000c constant ETZPC_ETZPC_DECPROT1_DECPROT1                    \ DECPROT1
$00000030 constant ETZPC_ETZPC_DECPROT1_DECPROT2                    \ DECPROT2
$000000c0 constant ETZPC_ETZPC_DECPROT1_DECPROT3                    \ DECPROT3
$00000300 constant ETZPC_ETZPC_DECPROT1_DECPROT4                    \ DECPROT4
$00000c00 constant ETZPC_ETZPC_DECPROT1_DECPROT5                    \ DECPROT5
$00003000 constant ETZPC_ETZPC_DECPROT1_DECPROT6                    \ DECPROT6
$0000c000 constant ETZPC_ETZPC_DECPROT1_DECPROT7                    \ DECPROT7
$00030000 constant ETZPC_ETZPC_DECPROT1_DECPROT8                    \ DECPROT8
$000c0000 constant ETZPC_ETZPC_DECPROT1_DECPROT9                    \ DECPROT9
$00300000 constant ETZPC_ETZPC_DECPROT1_DECPROT10                   \ DECPROT10
$00c00000 constant ETZPC_ETZPC_DECPROT1_DECPROT11                   \ DECPROT11
$03000000 constant ETZPC_ETZPC_DECPROT1_DECPROT12                   \ DECPROT12
$0c000000 constant ETZPC_ETZPC_DECPROT1_DECPROT13                   \ DECPROT13
$30000000 constant ETZPC_ETZPC_DECPROT1_DECPROT14                   \ DECPROT14
$c0000000 constant ETZPC_ETZPC_DECPROT1_DECPROT15                   \ DECPROT15


\
\ @brief Register reset values
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000003 constant ETZPC_ETZPC_DECPROT2_DECPROT0                    \ DECPROT0
$0000000c constant ETZPC_ETZPC_DECPROT2_DECPROT1                    \ DECPROT1
$00000030 constant ETZPC_ETZPC_DECPROT2_DECPROT2                    \ DECPROT2
$000000c0 constant ETZPC_ETZPC_DECPROT2_DECPROT3                    \ DECPROT3
$00000300 constant ETZPC_ETZPC_DECPROT2_DECPROT4                    \ DECPROT4
$00000c00 constant ETZPC_ETZPC_DECPROT2_DECPROT5                    \ DECPROT5
$00003000 constant ETZPC_ETZPC_DECPROT2_DECPROT6                    \ DECPROT6
$0000c000 constant ETZPC_ETZPC_DECPROT2_DECPROT7                    \ DECPROT7
$00030000 constant ETZPC_ETZPC_DECPROT2_DECPROT8                    \ DECPROT8
$000c0000 constant ETZPC_ETZPC_DECPROT2_DECPROT9                    \ DECPROT9
$00300000 constant ETZPC_ETZPC_DECPROT2_DECPROT10                   \ DECPROT10
$00c00000 constant ETZPC_ETZPC_DECPROT2_DECPROT11                   \ DECPROT11
$03000000 constant ETZPC_ETZPC_DECPROT2_DECPROT12                   \ DECPROT12
$0c000000 constant ETZPC_ETZPC_DECPROT2_DECPROT13                   \ DECPROT13
$30000000 constant ETZPC_ETZPC_DECPROT2_DECPROT14                   \ DECPROT14
$c0000000 constant ETZPC_ETZPC_DECPROT2_DECPROT15                   \ DECPROT15


\
\ @brief Register reset values
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000003 constant ETZPC_ETZPC_DECPROT3_DECPROT0                    \ DECPROT0
$0000000c constant ETZPC_ETZPC_DECPROT3_DECPROT1                    \ DECPROT1
$00000030 constant ETZPC_ETZPC_DECPROT3_DECPROT2                    \ DECPROT2
$000000c0 constant ETZPC_ETZPC_DECPROT3_DECPROT3                    \ DECPROT3
$00000300 constant ETZPC_ETZPC_DECPROT3_DECPROT4                    \ DECPROT4
$00000c00 constant ETZPC_ETZPC_DECPROT3_DECPROT5                    \ DECPROT5
$00003000 constant ETZPC_ETZPC_DECPROT3_DECPROT6                    \ DECPROT6
$0000c000 constant ETZPC_ETZPC_DECPROT3_DECPROT7                    \ DECPROT7
$00030000 constant ETZPC_ETZPC_DECPROT3_DECPROT8                    \ DECPROT8
$000c0000 constant ETZPC_ETZPC_DECPROT3_DECPROT9                    \ DECPROT9
$00300000 constant ETZPC_ETZPC_DECPROT3_DECPROT10                   \ DECPROT10
$00c00000 constant ETZPC_ETZPC_DECPROT3_DECPROT11                   \ DECPROT11
$03000000 constant ETZPC_ETZPC_DECPROT3_DECPROT12                   \ DECPROT12
$0c000000 constant ETZPC_ETZPC_DECPROT3_DECPROT13                   \ DECPROT13
$30000000 constant ETZPC_ETZPC_DECPROT3_DECPROT14                   \ DECPROT14
$c0000000 constant ETZPC_ETZPC_DECPROT3_DECPROT15                   \ DECPROT15


\
\ @brief Register reset values
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000003 constant ETZPC_ETZPC_DECPROT4_DECPROT0                    \ DECPROT0
$0000000c constant ETZPC_ETZPC_DECPROT4_DECPROT1                    \ DECPROT1
$00000030 constant ETZPC_ETZPC_DECPROT4_DECPROT2                    \ DECPROT2
$000000c0 constant ETZPC_ETZPC_DECPROT4_DECPROT3                    \ DECPROT3
$00000300 constant ETZPC_ETZPC_DECPROT4_DECPROT4                    \ DECPROT4
$00000c00 constant ETZPC_ETZPC_DECPROT4_DECPROT5                    \ DECPROT5
$00003000 constant ETZPC_ETZPC_DECPROT4_DECPROT6                    \ DECPROT6
$0000c000 constant ETZPC_ETZPC_DECPROT4_DECPROT7                    \ DECPROT7
$00030000 constant ETZPC_ETZPC_DECPROT4_DECPROT8                    \ DECPROT8
$000c0000 constant ETZPC_ETZPC_DECPROT4_DECPROT9                    \ DECPROT9
$00300000 constant ETZPC_ETZPC_DECPROT4_DECPROT10                   \ DECPROT10
$00c00000 constant ETZPC_ETZPC_DECPROT4_DECPROT11                   \ DECPROT11
$03000000 constant ETZPC_ETZPC_DECPROT4_DECPROT12                   \ DECPROT12
$0c000000 constant ETZPC_ETZPC_DECPROT4_DECPROT13                   \ DECPROT13
$30000000 constant ETZPC_ETZPC_DECPROT4_DECPROT14                   \ DECPROT14
$c0000000 constant ETZPC_ETZPC_DECPROT4_DECPROT15                   \ DECPROT15


\
\ @brief Register reset values
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000003 constant ETZPC_ETZPC_DECPROT5_DECPROT0                    \ DECPROT0
$0000000c constant ETZPC_ETZPC_DECPROT5_DECPROT1                    \ DECPROT1
$00000030 constant ETZPC_ETZPC_DECPROT5_DECPROT2                    \ DECPROT2
$000000c0 constant ETZPC_ETZPC_DECPROT5_DECPROT3                    \ DECPROT3
$00000300 constant ETZPC_ETZPC_DECPROT5_DECPROT4                    \ DECPROT4
$00000c00 constant ETZPC_ETZPC_DECPROT5_DECPROT5                    \ DECPROT5
$00003000 constant ETZPC_ETZPC_DECPROT5_DECPROT6                    \ DECPROT6
$0000c000 constant ETZPC_ETZPC_DECPROT5_DECPROT7                    \ DECPROT7
$00030000 constant ETZPC_ETZPC_DECPROT5_DECPROT8                    \ DECPROT8
$000c0000 constant ETZPC_ETZPC_DECPROT5_DECPROT9                    \ DECPROT9
$00300000 constant ETZPC_ETZPC_DECPROT5_DECPROT10                   \ DECPROT10
$00c00000 constant ETZPC_ETZPC_DECPROT5_DECPROT11                   \ DECPROT11
$03000000 constant ETZPC_ETZPC_DECPROT5_DECPROT12                   \ DECPROT12
$0c000000 constant ETZPC_ETZPC_DECPROT5_DECPROT13                   \ DECPROT13
$30000000 constant ETZPC_ETZPC_DECPROT5_DECPROT14                   \ DECPROT14
$c0000000 constant ETZPC_ETZPC_DECPROT5_DECPROT15                   \ DECPROT15


\
\ @brief ETZPC decprot lock 0 register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK0                  \ LOCK0
$00000002 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK1                  \ LOCK1
$00000004 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK2                  \ LOCK2
$00000008 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK3                  \ LOCK3
$00000010 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK4                  \ LOCK4
$00000020 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK5                  \ LOCK5
$00000040 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK6                  \ LOCK6
$00000080 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK7                  \ LOCK7
$00000100 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK8                  \ LOCK8
$00000200 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK9                  \ LOCK9
$00000400 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK10                 \ LOCK10
$00000800 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK11                 \ LOCK11
$00001000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK12                 \ LOCK12
$00002000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK13                 \ LOCK13
$00004000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK14                 \ LOCK14
$00008000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK15                 \ LOCK15
$00010000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK16                 \ LOCK16
$00020000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK17                 \ LOCK17
$00040000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK18                 \ LOCK18
$00080000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK19                 \ LOCK19
$00100000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK20                 \ LOCK20
$00200000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK21                 \ LOCK21
$00400000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK22                 \ LOCK22
$00800000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK23                 \ LOCK23
$01000000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK24                 \ LOCK24
$02000000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK25                 \ LOCK25
$04000000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK26                 \ LOCK26
$08000000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK27                 \ LOCK27
$10000000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK28                 \ LOCK28
$20000000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK29                 \ LOCK29
$40000000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK30                 \ LOCK30
$80000000 constant ETZPC_ETZPC_DECPROT_LOCK0_LOCK31                 \ LOCK31


\
\ @brief ETZPC decprot lock 1 register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK0                  \ LOCK0
$00000002 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK1                  \ LOCK1
$00000004 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK2                  \ LOCK2
$00000008 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK3                  \ LOCK3
$00000010 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK4                  \ LOCK4
$00000020 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK5                  \ LOCK5
$00000040 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK6                  \ LOCK6
$00000080 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK7                  \ LOCK7
$00000100 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK8                  \ LOCK8
$00000200 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK9                  \ LOCK9
$00000400 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK10                 \ LOCK10
$00000800 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK11                 \ LOCK11
$00001000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK12                 \ LOCK12
$00002000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK13                 \ LOCK13
$00004000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK14                 \ LOCK14
$00008000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK15                 \ LOCK15
$00010000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK16                 \ LOCK16
$00020000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK17                 \ LOCK17
$00040000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK18                 \ LOCK18
$00080000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK19                 \ LOCK19
$00100000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK20                 \ LOCK20
$00200000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK21                 \ LOCK21
$00400000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK22                 \ LOCK22
$00800000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK23                 \ LOCK23
$01000000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK24                 \ LOCK24
$02000000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK25                 \ LOCK25
$04000000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK26                 \ LOCK26
$08000000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK27                 \ LOCK27
$10000000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK28                 \ LOCK28
$20000000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK29                 \ LOCK29
$40000000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK30                 \ LOCK30
$80000000 constant ETZPC_ETZPC_DECPROT_LOCK1_LOCK31                 \ LOCK31


\
\ @brief ETZPC decprot lock 2 register
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK0                  \ LOCK0
$00000002 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK1                  \ LOCK1
$00000004 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK2                  \ LOCK2
$00000008 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK3                  \ LOCK3
$00000010 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK4                  \ LOCK4
$00000020 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK5                  \ LOCK5
$00000040 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK6                  \ LOCK6
$00000080 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK7                  \ LOCK7
$00000100 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK8                  \ LOCK8
$00000200 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK9                  \ LOCK9
$00000400 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK10                 \ LOCK10
$00000800 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK11                 \ LOCK11
$00001000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK12                 \ LOCK12
$00002000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK13                 \ LOCK13
$00004000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK14                 \ LOCK14
$00008000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK15                 \ LOCK15
$00010000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK16                 \ LOCK16
$00020000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK17                 \ LOCK17
$00040000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK18                 \ LOCK18
$00080000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK19                 \ LOCK19
$00100000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK20                 \ LOCK20
$00200000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK21                 \ LOCK21
$00400000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK22                 \ LOCK22
$00800000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK23                 \ LOCK23
$01000000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK24                 \ LOCK24
$02000000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK25                 \ LOCK25
$04000000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK26                 \ LOCK26
$08000000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK27                 \ LOCK27
$10000000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK28                 \ LOCK28
$20000000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK29                 \ LOCK29
$40000000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK30                 \ LOCK30
$80000000 constant ETZPC_ETZPC_DECPROT_LOCK2_LOCK31                 \ LOCK31


\
\ @brief ETZPC IP HW configuration register
\ Address offset: 0x3F0
\ Reset value: 0x00006002
\

$000000ff constant ETZPC_ETZPC_HWCFGR_NUM_TZMA                      \ NUM_TZMA
$0000ff00 constant ETZPC_ETZPC_HWCFGR_NUM_PER_SEC                   \ NUM_PER_SEC
$00ff0000 constant ETZPC_ETZPC_HWCFGR_NUM_AHB_SEC                   \ NUM_AHB_SEC
$ff000000 constant ETZPC_ETZPC_HWCFGR_CHUNKS1N4                     \ CHUNKS1N4


\
\ @brief ETZPC IP version register
\ Address offset: 0x3F4
\ Reset value: 0x00000020
\

$0000000f constant ETZPC_ETZPC_VERR_MINREV                          \ MINREV
$000000f0 constant ETZPC_ETZPC_VERR_MAJREV                          \ MAJREV


\
\ @brief ETZPC IP version register
\ Address offset: 0x3F8
\ Reset value: 0x00100061
\

$00000000 constant ETZPC_ETZPC_IDR_ID                               \ ID


\
\ @brief ETZPC IP version register
\ Address offset: 0x3FC
\ Reset value: 0xA3C5DD01
\

$00000000 constant ETZPC_ETZPC_SIDR_SID                             \ SID


\
\ @brief ETZPC
\
$5c007000 constant ETZPC_ETZPC_TZMA0_SIZE  \ offset: 0x00 : ETZPC ROM secure size definition
$5c007004 constant ETZPC_ETZPC_TZMA1_SIZE  \ offset: 0x04 : ETZPC RAM secure size definition
$5c007010 constant ETZPC_ETZPC_DECPROT0  \ offset: 0x10 : Register reset values
$5c007014 constant ETZPC_ETZPC_DECPROT1  \ offset: 0x14 : Register reset values
$5c007018 constant ETZPC_ETZPC_DECPROT2  \ offset: 0x18 : Register reset values
$5c00701c constant ETZPC_ETZPC_DECPROT3  \ offset: 0x1C : Register reset values
$5c007020 constant ETZPC_ETZPC_DECPROT4  \ offset: 0x20 : Register reset values
$5c007024 constant ETZPC_ETZPC_DECPROT5  \ offset: 0x24 : Register reset values
$5c007030 constant ETZPC_ETZPC_DECPROT_LOCK0  \ offset: 0x30 : ETZPC decprot lock 0 register
$5c007034 constant ETZPC_ETZPC_DECPROT_LOCK1  \ offset: 0x34 : ETZPC decprot lock 1 register
$5c007038 constant ETZPC_ETZPC_DECPROT_LOCK2  \ offset: 0x38 : ETZPC decprot lock 2 register
$5c0073f0 constant ETZPC_ETZPC_HWCFGR  \ offset: 0x3F0 : ETZPC IP HW configuration register
$5c0073f4 constant ETZPC_ETZPC_VERR  \ offset: 0x3F4 : ETZPC IP version register
$5c0073f8 constant ETZPC_ETZPC_IDR  \ offset: 0x3F8 : ETZPC IP version register
$5c0073fc constant ETZPC_ETZPC_SIDR  \ offset: 0x3FC : ETZPC IP version register

