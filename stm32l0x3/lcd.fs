\
\ @file lcd.fs
\ @brief Liquid crystal display controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant LCD_CR_LCDEN                                     \ LCD controller enable
$00000002 constant LCD_CR_VSEL                                      \ Voltage source selection
$0000001c constant LCD_CR_DUTY                                      \ Duty selection
$00000060 constant LCD_CR_BIAS                                      \ Bias selector
$00000080 constant LCD_CR_MUX_SEG                                   \ Mux segment enable


\
\ @brief frame control register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant LCD_FCR_HD                                       \ High drive enable
$00000002 constant LCD_FCR_SOFIE                                    \ Start of frame interrupt enable
$00000008 constant LCD_FCR_UDDIE                                    \ Update display done interrupt enable
$00000070 constant LCD_FCR_PON                                      \ Pulse ON duration
$00000380 constant LCD_FCR_DEAD                                     \ Dead time duration
$00001c00 constant LCD_FCR_CC                                       \ Contrast control
$0000e000 constant LCD_FCR_BLINKF                                   \ Blink frequency selection
$00030000 constant LCD_FCR_BLINK                                    \ Blink mode selection
$003c0000 constant LCD_FCR_DIV                                      \ DIV clock divider
$03c00000 constant LCD_FCR_PS                                       \ PS 16-bit prescaler


\
\ @brief status register
\ Address offset: 0x08
\ Reset value: 0x00000020
\

$00000001 constant LCD_SR_ENS                                       \ ENS
$00000002 constant LCD_SR_SOF                                       \ Start of frame flag
$00000004 constant LCD_SR_UDR                                       \ Update display request
$00000008 constant LCD_SR_UDD                                       \ Update Display Done
$00000010 constant LCD_SR_RDY                                       \ Ready flag
$00000020 constant LCD_SR_FCRSF                                     \ LCD Frame Control Register Synchronization flag


\
\ @brief clear register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000002 constant LCD_CLR_SOFC                                     \ Start of frame flag clear
$00000008 constant LCD_CLR_UDDC                                     \ Update display done clear


\
\ @brief display memory
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM0_0_S00                               \ S00
$00000002 constant LCD_RAM_COM0_0_S01                               \ S01
$00000004 constant LCD_RAM_COM0_0_S02                               \ S02
$00000008 constant LCD_RAM_COM0_0_S03                               \ S03
$00000010 constant LCD_RAM_COM0_0_S04                               \ S04
$00000020 constant LCD_RAM_COM0_0_S05                               \ S05
$00000040 constant LCD_RAM_COM0_0_S06                               \ S06
$00000080 constant LCD_RAM_COM0_0_S07                               \ S07
$00000100 constant LCD_RAM_COM0_0_S08                               \ S08
$00000200 constant LCD_RAM_COM0_0_S09                               \ S09
$00000400 constant LCD_RAM_COM0_0_S10                               \ S10
$00000800 constant LCD_RAM_COM0_0_S11                               \ S11
$00001000 constant LCD_RAM_COM0_0_S12                               \ S12
$00002000 constant LCD_RAM_COM0_0_S13                               \ S13
$00004000 constant LCD_RAM_COM0_0_S14                               \ S14
$00008000 constant LCD_RAM_COM0_0_S15                               \ S15
$00010000 constant LCD_RAM_COM0_0_S16                               \ S16
$00020000 constant LCD_RAM_COM0_0_S17                               \ S17
$00040000 constant LCD_RAM_COM0_0_S18                               \ S18
$00080000 constant LCD_RAM_COM0_0_S19                               \ S19
$00100000 constant LCD_RAM_COM0_0_S20                               \ S20
$00200000 constant LCD_RAM_COM0_0_S21                               \ S21
$00400000 constant LCD_RAM_COM0_0_S22                               \ S22
$00800000 constant LCD_RAM_COM0_0_S23                               \ S23
$01000000 constant LCD_RAM_COM0_0_S24                               \ S24
$02000000 constant LCD_RAM_COM0_0_S25                               \ S25
$04000000 constant LCD_RAM_COM0_0_S26                               \ S26
$08000000 constant LCD_RAM_COM0_0_S27                               \ S27
$10000000 constant LCD_RAM_COM0_0_S28                               \ S28
$20000000 constant LCD_RAM_COM0_0_S29                               \ S29
$40000000 constant LCD_RAM_COM0_0_S30                               \ S30
$80000000 constant LCD_RAM_COM0_0_S31                               \ S31


\
\ @brief display memory
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM0_1_S32                               \ S32
$00000002 constant LCD_RAM_COM0_1_S33                               \ S33
$00000004 constant LCD_RAM_COM0_1_S34                               \ S34
$00000008 constant LCD_RAM_COM0_1_S35                               \ S35
$00000010 constant LCD_RAM_COM0_1_S36                               \ S36
$00000020 constant LCD_RAM_COM0_1_S37                               \ S37
$00000040 constant LCD_RAM_COM0_1_S38                               \ S38
$00000080 constant LCD_RAM_COM0_1_S39                               \ S39
$00000100 constant LCD_RAM_COM0_1_S40                               \ S40
$00000200 constant LCD_RAM_COM0_1_S41                               \ S41
$00000400 constant LCD_RAM_COM0_1_S42                               \ S42
$00000800 constant LCD_RAM_COM0_1_S43                               \ S43
$00001000 constant LCD_RAM_COM0_1_S44                               \ S44
$00002000 constant LCD_RAM_COM0_1_S45                               \ S45
$00004000 constant LCD_RAM_COM0_1_S46                               \ S46
$00008000 constant LCD_RAM_COM0_1_S47                               \ S47
$00010000 constant LCD_RAM_COM0_1_S48                               \ S48
$00020000 constant LCD_RAM_COM0_1_S49                               \ S49
$00040000 constant LCD_RAM_COM0_1_S50                               \ S50
$00080000 constant LCD_RAM_COM0_1_S51                               \ S51


\
\ @brief display memory
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM1_0_S00                               \ S00
$00000002 constant LCD_RAM_COM1_0_S01                               \ S01
$00000004 constant LCD_RAM_COM1_0_S02                               \ S02
$00000008 constant LCD_RAM_COM1_0_S03                               \ S03
$00000010 constant LCD_RAM_COM1_0_S04                               \ S04
$00000020 constant LCD_RAM_COM1_0_S05                               \ S05
$00000040 constant LCD_RAM_COM1_0_S06                               \ S06
$00000080 constant LCD_RAM_COM1_0_S07                               \ S07
$00000100 constant LCD_RAM_COM1_0_S08                               \ S08
$00000200 constant LCD_RAM_COM1_0_S09                               \ S09
$00000400 constant LCD_RAM_COM1_0_S10                               \ S10
$00000800 constant LCD_RAM_COM1_0_S11                               \ S11
$00001000 constant LCD_RAM_COM1_0_S12                               \ S12
$00002000 constant LCD_RAM_COM1_0_S13                               \ S13
$00004000 constant LCD_RAM_COM1_0_S14                               \ S14
$00008000 constant LCD_RAM_COM1_0_S15                               \ S15
$00010000 constant LCD_RAM_COM1_0_S16                               \ S16
$00020000 constant LCD_RAM_COM1_0_S17                               \ S17
$00040000 constant LCD_RAM_COM1_0_S18                               \ S18
$00080000 constant LCD_RAM_COM1_0_S19                               \ S19
$00100000 constant LCD_RAM_COM1_0_S20                               \ S20
$00200000 constant LCD_RAM_COM1_0_S21                               \ S21
$00400000 constant LCD_RAM_COM1_0_S22                               \ S22
$00800000 constant LCD_RAM_COM1_0_S23                               \ S23
$01000000 constant LCD_RAM_COM1_0_S24                               \ S24
$02000000 constant LCD_RAM_COM1_0_S25                               \ S25
$04000000 constant LCD_RAM_COM1_0_S26                               \ S26
$08000000 constant LCD_RAM_COM1_0_S27                               \ S27
$10000000 constant LCD_RAM_COM1_0_S28                               \ S28
$20000000 constant LCD_RAM_COM1_0_S29                               \ S29
$40000000 constant LCD_RAM_COM1_0_S30                               \ S30
$80000000 constant LCD_RAM_COM1_0_S31                               \ S31


\
\ @brief display memory
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM1_1_S32                               \ S32
$00000002 constant LCD_RAM_COM1_1_S33                               \ S33
$00000004 constant LCD_RAM_COM1_1_S34                               \ S34
$00000008 constant LCD_RAM_COM1_1_S35                               \ S35
$00000010 constant LCD_RAM_COM1_1_S36                               \ S36
$00000020 constant LCD_RAM_COM1_1_S37                               \ S37
$00000040 constant LCD_RAM_COM1_1_S38                               \ S38
$00000080 constant LCD_RAM_COM1_1_S39                               \ S39
$00000100 constant LCD_RAM_COM1_1_S40                               \ S40
$00000200 constant LCD_RAM_COM1_1_S41                               \ S41
$00000400 constant LCD_RAM_COM1_1_S42                               \ S42
$00000800 constant LCD_RAM_COM1_1_S43                               \ S43
$00001000 constant LCD_RAM_COM1_1_S44                               \ S44
$00002000 constant LCD_RAM_COM1_1_S45                               \ S45
$00004000 constant LCD_RAM_COM1_1_S46                               \ S46
$00008000 constant LCD_RAM_COM1_1_S47                               \ S47
$00010000 constant LCD_RAM_COM1_1_S48                               \ S48
$00020000 constant LCD_RAM_COM1_1_S49                               \ S49
$00040000 constant LCD_RAM_COM1_1_S50                               \ S50
$00080000 constant LCD_RAM_COM1_1_S51                               \ S51


\
\ @brief display memory
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM2_0_S00                               \ S00
$00000002 constant LCD_RAM_COM2_0_S01                               \ S01
$00000004 constant LCD_RAM_COM2_0_S02                               \ S02
$00000008 constant LCD_RAM_COM2_0_S03                               \ S03
$00000010 constant LCD_RAM_COM2_0_S04                               \ S04
$00000020 constant LCD_RAM_COM2_0_S05                               \ S05
$00000040 constant LCD_RAM_COM2_0_S06                               \ S06
$00000080 constant LCD_RAM_COM2_0_S07                               \ S07
$00000100 constant LCD_RAM_COM2_0_S08                               \ S08
$00000200 constant LCD_RAM_COM2_0_S09                               \ S09
$00000400 constant LCD_RAM_COM2_0_S10                               \ S10
$00000800 constant LCD_RAM_COM2_0_S11                               \ S11
$00001000 constant LCD_RAM_COM2_0_S12                               \ S12
$00002000 constant LCD_RAM_COM2_0_S13                               \ S13
$00004000 constant LCD_RAM_COM2_0_S14                               \ S14
$00008000 constant LCD_RAM_COM2_0_S15                               \ S15
$00010000 constant LCD_RAM_COM2_0_S16                               \ S16
$00020000 constant LCD_RAM_COM2_0_S17                               \ S17
$00040000 constant LCD_RAM_COM2_0_S18                               \ S18
$00080000 constant LCD_RAM_COM2_0_S19                               \ S19
$00100000 constant LCD_RAM_COM2_0_S20                               \ S20
$00200000 constant LCD_RAM_COM2_0_S21                               \ S21
$00400000 constant LCD_RAM_COM2_0_S22                               \ S22
$00800000 constant LCD_RAM_COM2_0_S23                               \ S23
$01000000 constant LCD_RAM_COM2_0_S24                               \ S24
$02000000 constant LCD_RAM_COM2_0_S25                               \ S25
$04000000 constant LCD_RAM_COM2_0_S26                               \ S26
$08000000 constant LCD_RAM_COM2_0_S27                               \ S27
$10000000 constant LCD_RAM_COM2_0_S28                               \ S28
$20000000 constant LCD_RAM_COM2_0_S29                               \ S29
$40000000 constant LCD_RAM_COM2_0_S30                               \ S30
$80000000 constant LCD_RAM_COM2_0_S31                               \ S31


\
\ @brief display memory
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM2_1_S32                               \ S32
$00000002 constant LCD_RAM_COM2_1_S33                               \ S33
$00000004 constant LCD_RAM_COM2_1_S34                               \ S34
$00000008 constant LCD_RAM_COM2_1_S35                               \ S35
$00000010 constant LCD_RAM_COM2_1_S36                               \ S36
$00000020 constant LCD_RAM_COM2_1_S37                               \ S37
$00000040 constant LCD_RAM_COM2_1_S38                               \ S38
$00000080 constant LCD_RAM_COM2_1_S39                               \ S39
$00000100 constant LCD_RAM_COM2_1_S40                               \ S40
$00000200 constant LCD_RAM_COM2_1_S41                               \ S41
$00000400 constant LCD_RAM_COM2_1_S42                               \ S42
$00000800 constant LCD_RAM_COM2_1_S43                               \ S43
$00001000 constant LCD_RAM_COM2_1_S44                               \ S44
$00002000 constant LCD_RAM_COM2_1_S45                               \ S45
$00004000 constant LCD_RAM_COM2_1_S46                               \ S46
$00008000 constant LCD_RAM_COM2_1_S47                               \ S47
$00010000 constant LCD_RAM_COM2_1_S48                               \ S48
$00020000 constant LCD_RAM_COM2_1_S49                               \ S49
$00040000 constant LCD_RAM_COM2_1_S50                               \ S50
$00080000 constant LCD_RAM_COM2_1_S51                               \ S51


\
\ @brief display memory
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM3_0_S00                               \ S00
$00000002 constant LCD_RAM_COM3_0_S01                               \ S01
$00000004 constant LCD_RAM_COM3_0_S02                               \ S02
$00000008 constant LCD_RAM_COM3_0_S03                               \ S03
$00000010 constant LCD_RAM_COM3_0_S04                               \ S04
$00000020 constant LCD_RAM_COM3_0_S05                               \ S05
$00000040 constant LCD_RAM_COM3_0_S06                               \ S06
$00000080 constant LCD_RAM_COM3_0_S07                               \ S07
$00000100 constant LCD_RAM_COM3_0_S08                               \ S08
$00000200 constant LCD_RAM_COM3_0_S09                               \ S09
$00000400 constant LCD_RAM_COM3_0_S10                               \ S10
$00000800 constant LCD_RAM_COM3_0_S11                               \ S11
$00001000 constant LCD_RAM_COM3_0_S12                               \ S12
$00002000 constant LCD_RAM_COM3_0_S13                               \ S13
$00004000 constant LCD_RAM_COM3_0_S14                               \ S14
$00008000 constant LCD_RAM_COM3_0_S15                               \ S15
$00010000 constant LCD_RAM_COM3_0_S16                               \ S16
$00020000 constant LCD_RAM_COM3_0_S17                               \ S17
$00040000 constant LCD_RAM_COM3_0_S18                               \ S18
$00080000 constant LCD_RAM_COM3_0_S19                               \ S19
$00100000 constant LCD_RAM_COM3_0_S20                               \ S20
$00200000 constant LCD_RAM_COM3_0_S21                               \ S21
$00400000 constant LCD_RAM_COM3_0_S22                               \ S22
$00800000 constant LCD_RAM_COM3_0_S23                               \ S23
$01000000 constant LCD_RAM_COM3_0_S24                               \ S24
$02000000 constant LCD_RAM_COM3_0_S25                               \ S25
$04000000 constant LCD_RAM_COM3_0_S26                               \ S26
$08000000 constant LCD_RAM_COM3_0_S27                               \ S27
$10000000 constant LCD_RAM_COM3_0_S28                               \ S28
$20000000 constant LCD_RAM_COM3_0_S29                               \ S29
$40000000 constant LCD_RAM_COM3_0_S30                               \ S30
$80000000 constant LCD_RAM_COM3_0_S31                               \ S31


\
\ @brief display memory
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM3_1_S32                               \ S32
$00000002 constant LCD_RAM_COM3_1_S33                               \ S33
$00000004 constant LCD_RAM_COM3_1_S34                               \ S34
$00000008 constant LCD_RAM_COM3_1_S35                               \ S35
$00000010 constant LCD_RAM_COM3_1_S36                               \ S36
$00000020 constant LCD_RAM_COM3_1_S37                               \ S37
$00000040 constant LCD_RAM_COM3_1_S38                               \ S38
$00000080 constant LCD_RAM_COM3_1_S39                               \ S39
$00000100 constant LCD_RAM_COM3_1_S40                               \ S40
$00000200 constant LCD_RAM_COM3_1_S41                               \ S41
$00000400 constant LCD_RAM_COM3_1_S42                               \ S42
$00000800 constant LCD_RAM_COM3_1_S43                               \ S43
$00001000 constant LCD_RAM_COM3_1_S44                               \ S44
$00002000 constant LCD_RAM_COM3_1_S45                               \ S45
$00004000 constant LCD_RAM_COM3_1_S46                               \ S46
$00008000 constant LCD_RAM_COM3_1_S47                               \ S47
$00010000 constant LCD_RAM_COM3_1_S48                               \ S48
$00020000 constant LCD_RAM_COM3_1_S49                               \ S49
$00040000 constant LCD_RAM_COM3_1_S50                               \ S50
$00080000 constant LCD_RAM_COM3_1_S51                               \ S51


\
\ @brief display memory
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM4_0_S00                               \ S00
$00000002 constant LCD_RAM_COM4_0_S01                               \ S01
$00000004 constant LCD_RAM_COM4_0_S02                               \ S02
$00000008 constant LCD_RAM_COM4_0_S03                               \ S03
$00000010 constant LCD_RAM_COM4_0_S04                               \ S04
$00000020 constant LCD_RAM_COM4_0_S05                               \ S05
$00000040 constant LCD_RAM_COM4_0_S06                               \ S06
$00000080 constant LCD_RAM_COM4_0_S07                               \ S07
$00000100 constant LCD_RAM_COM4_0_S08                               \ S08
$00000200 constant LCD_RAM_COM4_0_S09                               \ S09
$00000400 constant LCD_RAM_COM4_0_S10                               \ S10
$00000800 constant LCD_RAM_COM4_0_S11                               \ S11
$00001000 constant LCD_RAM_COM4_0_S12                               \ S12
$00002000 constant LCD_RAM_COM4_0_S13                               \ S13
$00004000 constant LCD_RAM_COM4_0_S14                               \ S14
$00008000 constant LCD_RAM_COM4_0_S15                               \ S15
$00010000 constant LCD_RAM_COM4_0_S16                               \ S16
$00020000 constant LCD_RAM_COM4_0_S17                               \ S17
$00040000 constant LCD_RAM_COM4_0_S18                               \ S18
$00080000 constant LCD_RAM_COM4_0_S19                               \ S19
$00100000 constant LCD_RAM_COM4_0_S20                               \ S20
$00200000 constant LCD_RAM_COM4_0_S21                               \ S21
$00400000 constant LCD_RAM_COM4_0_S22                               \ S22
$00800000 constant LCD_RAM_COM4_0_S23                               \ S23
$01000000 constant LCD_RAM_COM4_0_S24                               \ S24
$02000000 constant LCD_RAM_COM4_0_S25                               \ S25
$04000000 constant LCD_RAM_COM4_0_S26                               \ S26
$08000000 constant LCD_RAM_COM4_0_S27                               \ S27
$10000000 constant LCD_RAM_COM4_0_S28                               \ S28
$20000000 constant LCD_RAM_COM4_0_S29                               \ S29
$40000000 constant LCD_RAM_COM4_0_S30                               \ S30
$80000000 constant LCD_RAM_COM4_0_S31                               \ S31


\
\ @brief display memory
\ Address offset: 0x38
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM4_1_S32                               \ S32
$00000002 constant LCD_RAM_COM4_1_S33                               \ S33
$00000004 constant LCD_RAM_COM4_1_S34                               \ S34
$00000008 constant LCD_RAM_COM4_1_S35                               \ S35
$00000010 constant LCD_RAM_COM4_1_S36                               \ S36
$00000020 constant LCD_RAM_COM4_1_S37                               \ S37
$00000040 constant LCD_RAM_COM4_1_S38                               \ S38
$00000080 constant LCD_RAM_COM4_1_S39                               \ S39
$00000100 constant LCD_RAM_COM4_1_S40                               \ S40
$00000200 constant LCD_RAM_COM4_1_S41                               \ S41
$00000400 constant LCD_RAM_COM4_1_S42                               \ S42
$00000800 constant LCD_RAM_COM4_1_S43                               \ S43
$00001000 constant LCD_RAM_COM4_1_S44                               \ S44
$00002000 constant LCD_RAM_COM4_1_S45                               \ S45
$00004000 constant LCD_RAM_COM4_1_S46                               \ S46
$00008000 constant LCD_RAM_COM4_1_S47                               \ S47


\
\ @brief display memory
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM5_0_S00                               \ S00
$00000002 constant LCD_RAM_COM5_0_S01                               \ S01
$00000004 constant LCD_RAM_COM5_0_S02                               \ S02
$00000008 constant LCD_RAM_COM5_0_S03                               \ S03
$00000010 constant LCD_RAM_COM5_0_S04                               \ S04
$00000020 constant LCD_RAM_COM5_0_S05                               \ S05
$00000040 constant LCD_RAM_COM5_0_S06                               \ S06
$00000080 constant LCD_RAM_COM5_0_S07                               \ S07
$00000100 constant LCD_RAM_COM5_0_S08                               \ S08
$00000200 constant LCD_RAM_COM5_0_S09                               \ S09
$00000400 constant LCD_RAM_COM5_0_S10                               \ S10
$00000800 constant LCD_RAM_COM5_0_S11                               \ S11
$00001000 constant LCD_RAM_COM5_0_S12                               \ S12
$00002000 constant LCD_RAM_COM5_0_S13                               \ S13
$00004000 constant LCD_RAM_COM5_0_S14                               \ S14
$00008000 constant LCD_RAM_COM5_0_S15                               \ S15
$00010000 constant LCD_RAM_COM5_0_S16                               \ S16
$00020000 constant LCD_RAM_COM5_0_S17                               \ S17
$00040000 constant LCD_RAM_COM5_0_S18                               \ S18
$00080000 constant LCD_RAM_COM5_0_S19                               \ S19
$00100000 constant LCD_RAM_COM5_0_S20                               \ S20
$00200000 constant LCD_RAM_COM5_0_S21                               \ S21
$00400000 constant LCD_RAM_COM5_0_S22                               \ S22
$00800000 constant LCD_RAM_COM5_0_S23                               \ S23
$01000000 constant LCD_RAM_COM5_0_S24                               \ S24
$02000000 constant LCD_RAM_COM5_0_S25                               \ S25
$04000000 constant LCD_RAM_COM5_0_S26                               \ S26
$08000000 constant LCD_RAM_COM5_0_S27                               \ S27
$10000000 constant LCD_RAM_COM5_0_S28                               \ S28
$20000000 constant LCD_RAM_COM5_0_S29                               \ S29
$40000000 constant LCD_RAM_COM5_0_S30                               \ S30
$80000000 constant LCD_RAM_COM5_0_S31                               \ S31


\
\ @brief display memory
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM5_1_S32                               \ S32
$00000002 constant LCD_RAM_COM5_1_S33                               \ S33
$00000004 constant LCD_RAM_COM5_1_S34                               \ S34
$00000008 constant LCD_RAM_COM5_1_S35                               \ S35
$00000010 constant LCD_RAM_COM5_1_S36                               \ S36
$00000020 constant LCD_RAM_COM5_1_S37                               \ S37
$00000040 constant LCD_RAM_COM5_1_S38                               \ S38
$00000080 constant LCD_RAM_COM5_1_S39                               \ S39
$00000100 constant LCD_RAM_COM5_1_S40                               \ S40
$00000200 constant LCD_RAM_COM5_1_S41                               \ S41
$00000400 constant LCD_RAM_COM5_1_S42                               \ S42
$00000800 constant LCD_RAM_COM5_1_S43                               \ S43
$00001000 constant LCD_RAM_COM5_1_S44                               \ S44
$00002000 constant LCD_RAM_COM5_1_S45                               \ S45
$00004000 constant LCD_RAM_COM5_1_S46                               \ S46
$00008000 constant LCD_RAM_COM5_1_S47                               \ S47


\
\ @brief display memory
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM6_0_S00                               \ S00
$00000002 constant LCD_RAM_COM6_0_S01                               \ S01
$00000004 constant LCD_RAM_COM6_0_S02                               \ S02
$00000008 constant LCD_RAM_COM6_0_S03                               \ S03
$00000010 constant LCD_RAM_COM6_0_S04                               \ S04
$00000020 constant LCD_RAM_COM6_0_S05                               \ S05
$00000040 constant LCD_RAM_COM6_0_S06                               \ S06
$00000080 constant LCD_RAM_COM6_0_S07                               \ S07
$00000100 constant LCD_RAM_COM6_0_S08                               \ S08
$00000200 constant LCD_RAM_COM6_0_S09                               \ S09
$00000400 constant LCD_RAM_COM6_0_S10                               \ S10
$00000800 constant LCD_RAM_COM6_0_S11                               \ S11
$00001000 constant LCD_RAM_COM6_0_S12                               \ S12
$00002000 constant LCD_RAM_COM6_0_S13                               \ S13
$00004000 constant LCD_RAM_COM6_0_S14                               \ S14
$00008000 constant LCD_RAM_COM6_0_S15                               \ S15
$00010000 constant LCD_RAM_COM6_0_S16                               \ S16
$00020000 constant LCD_RAM_COM6_0_S17                               \ S17
$00040000 constant LCD_RAM_COM6_0_S18                               \ S18
$00080000 constant LCD_RAM_COM6_0_S19                               \ S19
$00100000 constant LCD_RAM_COM6_0_S20                               \ S20
$00200000 constant LCD_RAM_COM6_0_S21                               \ S21
$00400000 constant LCD_RAM_COM6_0_S22                               \ S22
$00800000 constant LCD_RAM_COM6_0_S23                               \ S23
$01000000 constant LCD_RAM_COM6_0_S24                               \ S24
$02000000 constant LCD_RAM_COM6_0_S25                               \ S25
$04000000 constant LCD_RAM_COM6_0_S26                               \ S26
$08000000 constant LCD_RAM_COM6_0_S27                               \ S27
$10000000 constant LCD_RAM_COM6_0_S28                               \ S28
$20000000 constant LCD_RAM_COM6_0_S29                               \ S29
$40000000 constant LCD_RAM_COM6_0_S30                               \ S30
$80000000 constant LCD_RAM_COM6_0_S31                               \ S31


\
\ @brief display memory
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM6_1_S32                               \ S32
$00000002 constant LCD_RAM_COM6_1_S33                               \ S33
$00000004 constant LCD_RAM_COM6_1_S34                               \ S34
$00000008 constant LCD_RAM_COM6_1_S35                               \ S35
$00000010 constant LCD_RAM_COM6_1_S36                               \ S36
$00000020 constant LCD_RAM_COM6_1_S37                               \ S37
$00000040 constant LCD_RAM_COM6_1_S38                               \ S38
$00000080 constant LCD_RAM_COM6_1_S39                               \ S39
$00000100 constant LCD_RAM_COM6_1_S40                               \ S40
$00000200 constant LCD_RAM_COM6_1_S41                               \ S41
$00000400 constant LCD_RAM_COM6_1_S42                               \ S42
$00000800 constant LCD_RAM_COM6_1_S43                               \ S43
$00001000 constant LCD_RAM_COM6_1_S44                               \ S44
$00002000 constant LCD_RAM_COM6_1_S45                               \ S45
$00004000 constant LCD_RAM_COM6_1_S46                               \ S46
$00008000 constant LCD_RAM_COM6_1_S47                               \ S47


\
\ @brief display memory
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM7_0_S00                               \ S00
$00000002 constant LCD_RAM_COM7_0_S01                               \ S01
$00000004 constant LCD_RAM_COM7_0_S02                               \ S02
$00000008 constant LCD_RAM_COM7_0_S03                               \ S03
$00000010 constant LCD_RAM_COM7_0_S04                               \ S04
$00000020 constant LCD_RAM_COM7_0_S05                               \ S05
$00000040 constant LCD_RAM_COM7_0_S06                               \ S06
$00000080 constant LCD_RAM_COM7_0_S07                               \ S07
$00000100 constant LCD_RAM_COM7_0_S08                               \ S08
$00000200 constant LCD_RAM_COM7_0_S09                               \ S09
$00000400 constant LCD_RAM_COM7_0_S10                               \ S10
$00000800 constant LCD_RAM_COM7_0_S11                               \ S11
$00001000 constant LCD_RAM_COM7_0_S12                               \ S12
$00002000 constant LCD_RAM_COM7_0_S13                               \ S13
$00004000 constant LCD_RAM_COM7_0_S14                               \ S14
$00008000 constant LCD_RAM_COM7_0_S15                               \ S15
$00010000 constant LCD_RAM_COM7_0_S16                               \ S16
$00020000 constant LCD_RAM_COM7_0_S17                               \ S17
$00040000 constant LCD_RAM_COM7_0_S18                               \ S18
$00080000 constant LCD_RAM_COM7_0_S19                               \ S19
$00100000 constant LCD_RAM_COM7_0_S20                               \ S20
$00200000 constant LCD_RAM_COM7_0_S21                               \ S21
$00400000 constant LCD_RAM_COM7_0_S22                               \ S22
$00800000 constant LCD_RAM_COM7_0_S23                               \ S23
$01000000 constant LCD_RAM_COM7_0_S24                               \ S24
$02000000 constant LCD_RAM_COM7_0_S25                               \ S25
$04000000 constant LCD_RAM_COM7_0_S26                               \ S26
$08000000 constant LCD_RAM_COM7_0_S27                               \ S27
$10000000 constant LCD_RAM_COM7_0_S28                               \ S28
$20000000 constant LCD_RAM_COM7_0_S29                               \ S29
$40000000 constant LCD_RAM_COM7_0_S30                               \ S30
$80000000 constant LCD_RAM_COM7_0_S31                               \ S31


\
\ @brief display memory
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000001 constant LCD_RAM_COM7_1_S32                               \ S32
$00000002 constant LCD_RAM_COM7_1_S33                               \ S33
$00000004 constant LCD_RAM_COM7_1_S34                               \ S34
$00000008 constant LCD_RAM_COM7_1_S35                               \ S35
$00000010 constant LCD_RAM_COM7_1_S36                               \ S36
$00000020 constant LCD_RAM_COM7_1_S37                               \ S37
$00000040 constant LCD_RAM_COM7_1_S38                               \ S38
$00000080 constant LCD_RAM_COM7_1_S39                               \ S39
$00000100 constant LCD_RAM_COM7_1_S40                               \ S40
$00000200 constant LCD_RAM_COM7_1_S41                               \ S41
$00000400 constant LCD_RAM_COM7_1_S42                               \ S42
$00000800 constant LCD_RAM_COM7_1_S43                               \ S43
$00001000 constant LCD_RAM_COM7_1_S44                               \ S44
$00002000 constant LCD_RAM_COM7_1_S45                               \ S45
$00004000 constant LCD_RAM_COM7_1_S46                               \ S46
$00008000 constant LCD_RAM_COM7_1_S47                               \ S47


\
\ @brief Liquid crystal display controller
\
$40002400 constant LCD_CR         \ offset: 0x00 : control register
$40002404 constant LCD_FCR        \ offset: 0x04 : frame control register
$40002408 constant LCD_SR         \ offset: 0x08 : status register
$4000240c constant LCD_CLR        \ offset: 0x0C : clear register
$40002414 constant LCD_RAM_COM0_0  \ offset: 0x14 : display memory
$40002418 constant LCD_RAM_COM0_1  \ offset: 0x18 : display memory
$4000241c constant LCD_RAM_COM1_0  \ offset: 0x1C : display memory
$40002420 constant LCD_RAM_COM1_1  \ offset: 0x20 : display memory
$40002424 constant LCD_RAM_COM2_0  \ offset: 0x24 : display memory
$40002428 constant LCD_RAM_COM2_1  \ offset: 0x28 : display memory
$4000242c constant LCD_RAM_COM3_0  \ offset: 0x2C : display memory
$40002430 constant LCD_RAM_COM3_1  \ offset: 0x30 : display memory
$40002434 constant LCD_RAM_COM4_0  \ offset: 0x34 : display memory
$40002438 constant LCD_RAM_COM4_1  \ offset: 0x38 : display memory
$4000243c constant LCD_RAM_COM5_0  \ offset: 0x3C : display memory
$40002440 constant LCD_RAM_COM5_1  \ offset: 0x40 : display memory
$40002444 constant LCD_RAM_COM6_0  \ offset: 0x44 : display memory
$40002448 constant LCD_RAM_COM6_1  \ offset: 0x48 : display memory
$4000244c constant LCD_RAM_COM7_0  \ offset: 0x4C : display memory
$40002450 constant LCD_RAM_COM7_1  \ offset: 0x50 : display memory

